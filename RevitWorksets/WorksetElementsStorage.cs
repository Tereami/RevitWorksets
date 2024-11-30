using Autodesk.Revit.DB;
using System.Collections.Generic;

namespace RevitWorksets
{
    public class WorksetElementsStorage
    {
        public string Name { get; set; } = string.Empty;

        public List<Element> Elements { get; set; } = new List<Element>();

        public WorksetElementsStorage(string name, List<Element> elements)
        {
            Name = name;
            Elements = elements;
        }

        public WorksetElementsStorage(string name, Element elem)
        {
            Name = name;
            Elements = new List<Element> { elem };
        }
    }
}
