using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class DatosHospital
    {
        public List<EmpleadoHospital> Empleados;
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
        public int Personas { get; set; }

        public DatosHospital()
        {
            this.Empleados = new List<EmpleadoHospital>();
        }
    }
}
