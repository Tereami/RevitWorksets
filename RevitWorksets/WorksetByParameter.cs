using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitWorksets
{
    [Serializable]
    public class WorksetByParameter : WorksetBy
    {
        public string ParameterName;
        public string ParameterValue;

        public WorksetByParameter()
        {

        }
    }
}
