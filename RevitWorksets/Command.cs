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
                Debug.WriteLine("File is not workshared document");
                return Result.Failed; ;
            }

            (InfosStorage storage, string xmlPath) = InfosStorage.Load();

            List<RevitCategory> allCategories = RevitCategory.LoadAllCategories(doc);
            FormMain form = new FormMain(storage, xmlPath, allCategories);
            if(form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                Debug.WriteLine("CANCELLED");
                return Result.Cancelled;
            }
            storage = form.Model;
            xmlPath = form.XmlPath;

            int counter = 0;
            using (Transaction t = new Transaction(doc))
            {
                t.Start("Создание рабочих наборов");

                if (storage.WorksetByCetagoryEnabled && storage.worksetsByCategory != null && storage.worksetsByCategory.Count > 0)
                {
                    Debug.WriteLine("Start worksets by category");
                    foreach (WorksetByCategory wb in storage.worksetsByCategory)
                    {
                        Debug.WriteLine("Current workset: " + wb.WorksetName);
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
                    Debug.WriteLine("Finish worksets by category");
                }

                if (storage.WorksetByFamilyEnabled && storage.worksetsByFamily != null && storage.worksetsByFamily.Count > 0)
                {
                    Debug.WriteLine("Start worksets by family names");
                    List<FamilyInstance> famIns = new FilteredElementCollector(doc)
                            .WhereElementIsNotElementType()
                            .OfClass(typeof(FamilyInstance))
                            .Cast<FamilyInstance>()
                            .ToList();
                    Debug.WriteLine("Family instances found: " + famIns.Count);
                    foreach (WorksetByFamily wb in storage.worksetsByFamily)
                    {
                        Debug.WriteLine("Current workset:" + wb.WorksetName);
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
                    Debug.WriteLine("Start worksets by family names");
                }

                Debug.WriteLine("Getting all model elements...");
                List<Element> allElems = new FilteredElementCollector(doc)
                                .WhereElementIsNotElementType()
                                .Cast<Element>()
                                .ToList();
                Debug.WriteLine("Elements found: " + allElems.Count);

                if (storage.WorksetByTypeEnabled && storage.worksetsByType != null && storage.worksetsByType.Count > 0)
                {
                    Debug.WriteLine("Start worksets by type names");
                    foreach (WorksetByType wb in storage.worksetsByType)
                    {
                        Debug.WriteLine("Current workset:" + wb.WorksetName);
                        Workset wset = wb.GetWorkset(doc);
                        List<string> typeNames = wb.TypeNames;
                        if (typeNames == null) continue;
                        if (typeNames.Count == 0) continue;

                        foreach (string typeName in typeNames)
                        {
                            foreach (Element elem in allElems)
                            {
                                ElementId typeId = elem.GetTypeId();
                                if (typeId == null || typeId == ElementId.InvalidElementId) continue;
                                ElementType elemType = doc.GetElement(typeId) as ElementType;
                                if (elemType == null) continue;
                                Debug.WriteLine("Element id: " + elem.Id.GetValue() + ", TypeName: " + elemType.Name);

                                if (elemType.Name.StartsWith(typeName))
                                {
                                    WorksetBy.SetWorkset(elem, wset);
                                    counter++;
                                }
                            }
                        }
                    }
                    Debug.WriteLine("Finish worksets by type names");
                }
                
                if(storage.worksetByParameter != null && storage.WorksetByParameterEnabled)
                {
                    Debug.WriteLine("Start worksets by parameters");
                    string paramName = storage.worksetByParameter.ParameterName;
                    foreach (Element elem in allElems)
                    {
                        Parameter p = elem.LookupParameter(paramName);
                        if (p == null) continue;
                        if (!p.HasValue) continue;
                        if(p.StorageType != StorageType.String)
                        {
                            string errmsg = "Parameter is not string: " + paramName;
                            Debug.WriteLine(errmsg);
                            throw new Exception(errmsg);
                        }
                        string wsetParamValue = p.AsString();
                        Workset wsetByparamval = WorksetBy.GetOrCreateWorkset(doc, wsetParamValue);
                        WorksetBy.SetWorkset(elem, wsetByparamval);
                        counter++;
                    }
                    Debug.WriteLine("Finish worksets by parameter");
                }


                if (storage.worksetByLink != null && storage.WorksetByLinkEnabled)
                {
                    Debug.WriteLine("Start worksets for link files");
                    WorksetByLink wsetbylink = storage.worksetByLink;
                    List<RevitLinkInstance> links = new FilteredElementCollector(doc)
                        .OfClass(typeof(RevitLinkInstance))
                        .Cast<RevitLinkInstance>()
                        .ToList();
                    Debug.WriteLine("Links found: " + links.Count);

                    foreach (RevitLinkInstance rli in links)
                    {
                        Debug.WriteLine("Current link: " + rli.Name);
                        RevitLinkType linkFileType = doc.GetElement(rli.GetTypeId()) as RevitLinkType;
                        if (linkFileType == null)
                        {
                            Debug.WriteLine("LinkType is invalid");
                            continue;
                        }
                        if (linkFileType.IsNestedLink)
                        {
                            Debug.WriteLine("It is nested link");
                            continue;
                        }

                        string linkWorksetName = wsetbylink.GetWorksetName(linkFileType.Name);

                        Workset linkWorkset = WorksetBy.GetOrCreateWorkset(doc, linkWorksetName);
                        WorksetBy.SetWorkset(rli, linkWorkset);
                        WorksetBy.SetWorkset(linkFileType, linkWorkset);
                        counter++;
                    }
                    Debug.WriteLine("Finish worksets for link files");
                }

                if(storage.worksetByDwg != null && storage.WorksetByDwgEnabled)
                {
                    Debug.WriteLine("Start workset for dwg links");
                    WorksetByDwg wsetDwg = storage.worksetByDwg;
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
                    Debug.WriteLine("Finish workset for dwg links");
                }

                Debug.WriteLine("Commit started");
                t.Commit();
                Debug.WriteLine("Commit succeded");
            }

            string msg = $"Обработано элементов: {counter}"; 
            List<string> emptyWorksetsNames = WorksetTool.GetEmptyWorksets(doc);
            if(emptyWorksetsNames.Count > 0)
            {
                msg += System.Environment.NewLine + "Обнаружены пустые рабочие наборы! Их можно удалить вручную:\n";
                msg += string.Join(System.Environment.NewLine, emptyWorksetsNames);
                Debug.WriteLine("Empty worksets found: " + msg);
            }
            BalloonTip.Show("Завершено!", msg);
            Debug.WriteLine(msg);

            storage.Save(xmlPath);
            return Result.Succeeded;
        }
    }
}
