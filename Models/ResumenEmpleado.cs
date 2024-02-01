using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class ResumenEmpleado
    {
        public List<string> Apellidos { get; set; }
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
        public int Personas { get; set; }
        public ResumenEmpleado()
        {
            this.Apellidos = new List<string>();
        }
    }
}
