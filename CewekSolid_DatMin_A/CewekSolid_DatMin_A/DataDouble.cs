using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CewekSolid_DatMin_A
{
    class DataDouble
    {
        private List<double> attribute;

        public DataDouble(List<double> attribute)
        {
            Attribute = attribute;
        }

        public List<double> Attribute { get => attribute; set => attribute = value; }
    }
}
