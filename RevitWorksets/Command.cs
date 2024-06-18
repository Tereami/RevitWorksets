#region License
/*Данный код опубликован под лицензией Creative Commons Attribution-ShareAlike.
Разрешено использовать, распространять, изменять и брать данный код за основу для производных в коммерческих и
некоммерческих целях, при условии указания авторства и если производные лицензируются на тех же условиях.
Код поставляется "как есть". Автор не несет ответственности за возможные последствия использования.
Зуев Александр, 2020, все права защищены.
This code is listed under the Creative Commons Attribution-ShareAlike license.
You may use, redistribute, remix, tweak, and build upon this work non-commercially and commercially,
as long as you credit the author by linking back and license your new creations under the same terms.
This code is provided 'as is'. Author disclaims any implied warranty.
Zuev Aleksandr, 2020, all rigths reserved.*/
#endregion
#region usings
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.DB; 
using Autodesk.Revit.UI;
using System.IO;
using System.Xml;
#endregion

namespace RevitWorksets
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new RbsLogger.Logger("Worksets"));
            Document doc = commandData.Application.ActiveUIDocument.Document;

            if(!doc.IsWorkshared)
            {
                message = "Файл не является файлом совместной работы";
                Trace.WriteLine("File os not workshared document");
                return Result.Failed; ;
            }

            //считываю список рабочих наборов
            string dllPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dllFolder = System.IO.Path.GetDirectoryName(dllPath);
            string folder = System.IO.Path.Combine(dllFolder, "RevitWorksets_data");
            Trace.WriteLine("Default folder for xmls: " + folder);

            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.InitialDirectory = folder;
            dialog.Multiselect = false;
            dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return Result.Cancelled;
            string xmlFilePath = dialog.FileName;
            Trace.WriteLine("Xml path: " + xmlFilePath);

            InfosStorage storage = new InfosStorage();
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(InfosStorage));
            using (StreamReader r = new StreamReader(xmlFilePath))
            {
                storage = (InfosStorage)serializer.Deserialize(r);
            }
            
            if(storage == null)
            {
                string errormsg = "Unable to deserialize: " + xmlFilePath.Replace("\\", " \\");
                Trace.WriteLine(errormsg);
                throw new Exception(errormsg);
            }
            Trace.WriteLine("Deserialize success");
            int counter = 0;

            using (Transaction t = new Transaction(doc))
            {
                t.Start("Создание рабочих наборов");

                Trace.WriteLine("Start worksets by category");
                foreach (WorksetByCategory wb in storage.worksetsByCategory)
                {
                    Trace.WriteLine("Current workset: " + wb.WorksetName);
                    Workset wset = wb.GetWorkset(doc);
                    List<BuiltInCategory> cats = wb.revitCategories;
                    if (cats == null) continue;
                    if (cats.Count == 0) continue;

                    foreach (BuiltInCategory bic in cats)
                    {
                        List<Element> elems = new FilteredElementCollector(doc)
                            .OfCategory(bic)
                            .WhereElementIsNotElementType()
                            .ToElements()
                            .ToList();
                        
                        foreach (Element elem in elems)
                        {
                            WorksetBy.SetWorkset(elem, wset);
                            counter++;
                        }
                    }
                }

                Trace.WriteLine("Start worksets by family names");
                List<FamilyInstance> famIns = new FilteredElementCollector(doc)
                        .WhereElementIsNotElementType()
                        .OfClass(typeof(FamilyInstance))
                        .Cast<FamilyInstance>()
                        .ToList();
                Trace.WriteLine("Family instances found: " + famIns.Count);
                foreach (WorksetByFamily wb in storage.worksetsByFamily)
                {
                    Trace.WriteLine("Current workset:" + wb.WorksetName);
                    Workset wset = wb.GetWorkset(doc);

                    List<string> families = wb.FamilyNames;
                    if (families == null) continue;
                    if (families.Count == 0) continue;

                    foreach (string familyName in families)
                    {
                        List<FamilyInstance> curFamIns = famIns
                            .Where(f => f.Symbol.FamilyName.StartsWith(familyName))
                            .ToList();
                        
                        foreach (FamilyInstance fi in curFamIns)
                        {
                            WorksetBy.SetWorkset(fi, wset);
                            counter++;
                        }
                    }
                }

                Trace.WriteLine("Start worksets by type names");
                List<Element> allElems = new FilteredElementCollector(doc)
                            .WhereElementIsNotElementType()
                            .Cast<Element>()
                            .ToList();
                Trace.WriteLine("Elements found: " + allElems.Count);

                foreach (WorksetByType wb in storage.worksetsByType)
                {
                    Trace.WriteLine("Current workset:" + wb.WorksetName);
                    Workset wset = wb.GetWorkset(doc);
                    List<string> typeNames = wb.TypeNames;
                    if (typeNames == null) continue;
                    if (typeNames.Count == 0) continue;

                    foreach(string typeName in typeNames)
                    {
                        foreach(Element elem in allElems)
                        {
                            ElementId typeId = elem.GetTypeId();
                            if (typeId == null || typeId == ElementId.InvalidElementId) continue;
                            ElementType elemType = doc.GetElement(typeId) as ElementType;
                            if (elemType == null) continue;
                            Trace.WriteLine("Element id: " + elem.Id.GetValue() + ", TypeName: " + elemType.Name);

                            if (elemType.Name.StartsWith(typeName))
                            {
                                WorksetBy.SetWorkset(elem, wset);
                                counter++;
                            }
                        }
                    }
                }
                
                if(storage.worksetByParameter != null)
                {
                    Trace.WriteLine("Start worksets by parameters");
                    string paramName = storage.worksetByParameter.ParameterName;
                    foreach (Element elem in allElems)
                    {
                        Parameter p = elem.LookupParameter(paramName);
                        if (p == null) continue;
                        if (!p.HasValue) continue;
                        if(p.StorageType != StorageType.String)
                        {
                            string errmsg = "Parameter is not string: " + paramName;
                            Trace.WriteLine(errmsg);
                            throw new Exception(errmsg);
                        }
                        string wsetParamValue = p.AsString();
                        Workset wsetByparamval = WorksetBy.GetOrCreateWorkset(doc, wsetParamValue);
                        WorksetBy.SetWorkset(elem, wsetByparamval);
                        counter++;
                    }
                }


                if (storage.worksetByLink != null)
                {
                    WorksetByLink wsetbylink = storage.worksetByLink;
                    Trace.WriteLine("Worksets for link files");
                    List<RevitLinkInstance> links = new FilteredElementCollector(doc)
                        .OfClass(typeof(RevitLinkInstance))
                        .Cast<RevitLinkInstance>()
                        .ToList();
                    Trace.WriteLine("Links found: " + links.Count);

                    foreach (RevitLinkInstance rli in links)
                    {
                        Trace.WriteLine("Current link: " + rli.Name);
                        RevitLinkType linkFileType = doc.GetElement(rli.GetTypeId()) as RevitLinkType;
                        if (linkFileType == null)
                        {
                            Trace.WriteLine("LinkType is invalid");
                            continue;
                        }
                        if (linkFileType.IsNestedLink)
                        {
                            Trace.WriteLine("It is nested link");
                            continue;
                        }
                        char separator = wsetbylink.separator[0];
                        string linkWorksetName1 = linkFileType.Name.Split(separator)[wsetbylink.partNumberAfterSeparator];
                        string linkWorksetName2 = linkWorksetName1
                            .Substring(wsetbylink.ignoreFirstCharsAfterSeparation, linkWorksetName1.Length - wsetbylink.ignoreLastCharsAfterSeparation);
                        string linkWorksetName = wsetbylink.prefixForLinkWorksets + linkWorksetName2;
                        Trace.WriteLine("Workset name: " + linkWorksetName);

                        Workset linkWorkset = WorksetBy.GetOrCreateWorkset(doc, linkWorksetName);
                        WorksetBy.SetWorkset(rli, linkWorkset);
                        WorksetBy.SetWorkset(linkFileType, linkWorkset);
                        counter++;
                    }
                }

                if(storage.worksetByDwg != null)
                {
                    WorksetByDwg wsetDwg = storage.worksetByDwg;
                    Trace.WriteLine("Workset for dwg links");
                    List<ImportInstance> linkInstances = new FilteredElementCollector(doc)
                        .OfClass(typeof(ImportInstance))
                        .Cast<ImportInstance>()
                        .ToList();
                    List<CADLinkType> linkTypes = new FilteredElementCollector(doc)
                        .OfClass(typeof(CADLinkType))
                        .Cast<CADLinkType>()
                        .ToList();

                    Workset dwgWorkset = WorksetBy.GetOrCreateWorkset(doc, wsetDwg.WorksetName);
                    foreach(ImportInstance ii in  linkInstances) 
                    {
                        WorksetBy.SetWorkset(ii, dwgWorkset);
                        counter++;
                    }
                    foreach(CADLinkType linkType in linkTypes)
                    {
                        WorksetBy.SetWorkset(linkType, dwgWorkset);
                        counter++;
                    }
                    Trace.WriteLine("Workset for dwg links complete");
                }

                t.Commit();
            }

            string msg = $"Обработано элементов: {counter}"; 
            List<string> emptyWorksetsNames = WorksetTool.GetEmptyWorksets(doc);
            if(emptyWorksetsNames.Count > 0)
            {
                msg += System.Environment.NewLine + "Обнаружены пустые рабочие наборы! Их можно удалить вручную:\n";
                foreach(string s in emptyWorksetsNames)
                {
                    msg += s + "\n";
                }
                Trace.WriteLine("Empty worksets found: " + msg);
            }
            BalloonTip.Show("Завершено!", msg);
            Trace.WriteLine("Finished");
            return Result.Succeeded;
        }
    }
}
