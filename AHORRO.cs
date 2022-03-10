using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    public class AHORRO : ALCANCIA
    {
        public override int MONEDA { get; set; }
        public AHORRO(int MONEDA)
        {
            this.MONEDA = MONEDA;
        }
        public AHORRO()
        {
        }
    }
}
