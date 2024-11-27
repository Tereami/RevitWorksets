using Autodesk.Revit.DB;
using System.Collections.Generic;
using System.Linq;

namespace RevitWorksets
{
    public class RevitCategory
    {
        public BuiltInCategory InternalCategory { get; set; }

        public string DisplayName { get; set; }

        public RevitCategory()
        {

        }

        public override string ToString()
        {
            return DisplayName;
        }

        public static List<RevitCategory> LoadAllCategories(Document doc)
        {
            List<RevitCategory> cats = new List<RevitCategory>();
            foreach (Category cat in doc.Settings.Categories)
            {
                if (cat.CategoryType == CategoryType.Model ||
                    (cat.CategoryType == CategoryType.Annotation && cat.AllowsBoundParameters))
                {
                    string name = cat.Name;
                    if (string.IsNullOrEmpty(name)) continue;

                    BuiltInCategory bic = (BuiltInCategory)cat.Id.GetValue();

                    RevitCategory rc = new RevitCategory { DisplayName = name, InternalCategory = bic };
                    cats.Add(rc);
                }
            }

            cats = cats.OrderBy(i => i.DisplayName).ToList();
            return cats;
        }
    }
}
