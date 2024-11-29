//using Autodesk.Revit.DB;
//using System.Collections.Generic;
//using System.Linq;

//namespace RevitWorksets
//{
//    public static class WorksetTool
//    {
//        public static List<string> GetEmptyWorksets(Document doc)
//        {
//            List<string> wnames = new List<string>();
//            if (!doc.IsWorkshared) return null;

//            List<Workset> wids = new FilteredWorksetCollector(doc)
//                .OfKind(WorksetKind.UserWorkset)
//                .ToWorksets()
//                .ToList();

//            foreach (Workset w in wids)
//            {
//                ElementWorksetFilter wfilter = new ElementWorksetFilter(w.Id);
//                FilteredElementCollector col = new FilteredElementCollector(doc).WherePasses(wfilter);
//                if (col.GetElementCount() == 0)
//                {
//                    wnames.Add(w.Name);
//                }
//            }
//            return wnames;
//        }
//    }
//}
