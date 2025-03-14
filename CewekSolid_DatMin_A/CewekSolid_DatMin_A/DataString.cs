using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CewekSolid_DatMin_A
{
    class DataString
    {
        private List<string> attribute;

        public DataString(List<string> attribute)
        {
            Attribute = attribute;
        }

        public List<string> Attribute { get => attribute; set => attribute = value; }
    }
}
