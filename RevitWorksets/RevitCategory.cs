using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitWorksets
{
    public class RevitCategory
    {
        public BuiltInCategory InternalCategory { get; set; }

        public string DisplayName { get; set; }

        public RevitCategory(BuiltInCategory bic)
        {
            InternalCategory = bic;
            DisplayName = LabelUtils.GetLabelFor(bic);
        }

        public override string ToString()
        {
            return DisplayName;
        }

        public static List<RevitCategory> LoadAllCategories(Document doc)
        {
            List<BuiltInCategory> bics = new List<BuiltInCategory>();
            foreach(Category cat in doc.Settings.Categories)
            {
                if(cat.CategoryType == CategoryType.Model || 
                    (cat.CategoryType == CategoryType.Annotation && cat.AllowsBoundParameters))
                {
                    BuiltInCategory bic = (BuiltInCategory)cat.Id.IntegerValue;
                    bics.Add(bic);
                }
            }

            List<RevitCategory> cats = bics
                .Where(i => Category.IsBuiltInCategoryValid(i))
                .Select(i => new RevitCategory(i))
                .OrderBy(i => i.DisplayName)
                .ToList();
            return cats;
        }
    }
}
