using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class estudiante : persona
    {
        //public int Edad { get; set; }
        //public String ESCUELA { get; set; }

        //public override int IDENTIFICACION { get; set; }

        public override int MONEDA { get; set; }

        //public override String APELLIDO { get; set; }

        //public override int SEXO { get; set; }

        public estudiante(int Edad, String ESCUELA, int IDENTIFICACION, int MONEDA, String APELLIDO, int SEXO)

        {
            //this.Edad = Edad;
            //this.ESCUELA = ESCUELA;
            //this.IDENTIFICACION = IDENTIFICACION;
            this.MONEDA = MONEDA;
            //this.APELLIDO = APELLIDO;
            //this.SEXO = SEXO;
        }

        public estudiante()
        {

        }
    }
}