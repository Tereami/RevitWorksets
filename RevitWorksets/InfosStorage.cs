using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RevitWorksets
{
    [Serializable]
    public class InfosStorage
    {
        public string ConfigurationName;

        public List<WorksetByCategory> worksetsByCategory;
        public List<WorksetByFamily> worksetsByFamily;
        public List<WorksetByType> worksetsByType;
        public List<WorksetByParameter> worksetsByParameter;

        public InfosStorage()
        {

        }
    }
}
