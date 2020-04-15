using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB; //для работы с элементами модели Revit
using Autodesk.Revit.UI; //для работы с элементами интерфейса
using Autodesk.Revit.ApplicationServices;
using System.IO;
using System.Xml;

namespace RevitWorksets
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            if(!doc.IsWorkshared)
            {
                message = "Файл не является файлом совместной работы";
                return Result.Failed; ;
            }

            //считываю список рабочих наборов
            string dllPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string folder = System.IO.Path.GetDirectoryName(dllPath);

            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.InitialDirectory = folder;
            dialog.Multiselect = false;
            dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return Result.Cancelled;
            string xmlFilePath = dialog.FileName;

            InfosStorage storage = new InfosStorage();
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(InfosStorage));
            using (StreamReader r = new StreamReader(xmlFilePath))
            {
                storage = (InfosStorage)serializer.Deserialize(r);
            }


            using (Transaction t = new Transaction(doc))
            {
                t.Start("Создание рабочих наборов");

                //назначаю рабочие наборы в случае, если указана категория
                foreach (WorksetByCategory wb in storage.worksetsByCategory)
                {
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
                        }
                    }
                }

                //назначаю рабочие наборы по именам семейств
                List<FamilyInstance> famIns = new FilteredElementCollector(doc)
                        .WhereElementIsNotElementType()
                        .OfClass(typeof(FamilyInstance))
                        .Cast<FamilyInstance>()
                        .ToList();
                foreach (WorksetByFamily wb in storage.worksetsByFamily)
                {
                    Workset wset = wb.GetWorkset(doc);

                    List<string> families = wb.FamilyNames;
                    if (families == null) continue;
                    if (families.Count == 0) continue;

                    

                    foreach (string familyName in families)
                    {
                        List<FamilyInstance> curFamIns = famIns
                            .Where(f => f.Symbol.FamilyName == familyName)
                            .ToList();
                        
                        foreach (FamilyInstance fi in curFamIns)
                        {
                            WorksetBy.SetWorkset(fi, wset);
                        }
                    }
                }

                //назначаю рабочие наборы по именам типов
                List<Element> allElems = new FilteredElementCollector(doc)
                            .WhereElementIsNotElementType()
                            .Cast<Element>()
                            .ToList();

                foreach (WorksetByType wb in storage.worksetsByType)
                {
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

                            if (elemType.Name == typeName)
                            {
                                WorksetBy.SetWorkset(elem, wset);
                            }
                        }
                    }
                }

                //назначаю рабочие наборы по значению параметров
                foreach(WorksetByParameter wb in storage.worksetsByParameter)
                {
                    Workset wset = wb.GetWorkset(doc);
                    string paramName = wb.ParameterName;
                    string paramValue = wb.ParameterValue;

                    List<Element> elemsFilterByParam = allElems
                        .Where(e => e.LookupParameter(paramName).AsString().Equals(paramValue)).ToList();

                    foreach(Element elem in elemsFilterByParam)
                    {
                        WorksetBy.SetWorkset(elem, wset);
                    }
                }


                //назначаю рабочие наборы для связанных файлов
                List<RevitLinkInstance> links = new FilteredElementCollector(doc)
                    .OfClass(typeof(RevitLinkInstance))
                    .Cast<RevitLinkInstance>()
                    .ToList();

                foreach(RevitLinkInstance rli in links)
                {
                    RevitLinkType linkFileType = doc.GetElement(rli.GetTypeId()) as RevitLinkType;
                    if (linkFileType == null) continue;
                    if (linkFileType.IsNestedLink) continue;

                    string linkWorksetName = "#" + rli.Name;
                    bool checkExists = WorksetTable.IsWorksetNameUnique(doc, linkWorksetName);
                    if (!checkExists) continue;

                    Workset.Create(doc, linkWorksetName);

                    Workset linkWorkset = new FilteredWorksetCollector(doc)
                        .OfKind(WorksetKind.UserWorkset)
                        .ToWorksets()
                        .Where(w => w.Name == linkWorksetName)
                        .First();

                    WorksetBy.SetWorkset(rli, linkWorkset);
                    WorksetBy.SetWorkset(linkFileType, linkWorkset);
                }

                t.Commit();
            }

            return Result.Succeeded;
        }
    }
}
