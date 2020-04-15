using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitWorksets
{
    [Serializable]
    public class WorksetByFamily : WorksetBy
    {
        public List<string> FamilyNames;

        public WorksetByFamily()
        {

        }
    }
}
