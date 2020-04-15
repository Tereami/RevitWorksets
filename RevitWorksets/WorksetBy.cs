using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace RevitWorksets
{
    public abstract class WorksetBy
    {
        public string WorksetName;

        public Workset GetWorkset(Document doc)
        {
            IList<Workset> userWorksets = new FilteredWorksetCollector(doc)
                .OfKind(WorksetKind.UserWorkset)
                .ToWorksets();

            bool checkNotExists = WorksetTable.IsWorksetNameUnique(doc, WorksetName);

            if (!checkNotExists)
            {
                Workset wset = new FilteredWorksetCollector(doc)
                .OfKind(WorksetKind.UserWorkset)
                .ToWorksets()
                .Where(w => w.Name == WorksetName)
                .First();
                return wset;
            }
            else
            {
                Workset wset = Workset.Create(doc, WorksetName);
                return wset;
            }
        }


        public static void SetWorkset(Element elem, Workset w)
        {
            Parameter wsparam = elem.get_Parameter(BuiltInParameter.ELEM_PARTITION_PARAM);
            if (wsparam == null) return;
            if (wsparam.IsReadOnly) return;

            bool elemNonGroup = (elem.GroupId == null) || (elem.GroupId == ElementId.InvalidElementId);

            if (elemNonGroup)
            {
                wsparam.Set(w.Id.IntegerValue);
            }
            else
            {
                Group gr = elem.Document.GetElement(elem.GroupId) as Group;
                SetWorkset(gr, w);
            }
        }
    }
}
