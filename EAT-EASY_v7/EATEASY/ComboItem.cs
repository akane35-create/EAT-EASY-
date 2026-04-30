using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATEASY
{
    public class ComboItem
    {
        public string Texto { get; set; }
        public int Valor { get; set; }

        public override string ToString()
        {
            return Texto;
        }
    }
}
