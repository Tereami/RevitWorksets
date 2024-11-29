using Autodesk.Revit.DB;
using System.Collections.Generic;

namespace RevitWorksets
{
    public class WorksetElements
    {
        public Workset RevitWorkset { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<Element> Elements { get; set; } = new List<Element>();

        public WorksetElements(string name, List<Element> elements)
        {
            Name = name;
            Elements = elements;
        }

        public WorksetElements(string name, Element elem)
        {
            Name = name;
            Elements = new List<Element> { elem };
        }
    }
}
