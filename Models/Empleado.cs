using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class Empleado
    {
        public int EMP_NO { get; set; }
        public string APELLIDO { get; set; }
        public string OFICIO { get; set; }
        public int DIR { get; set; }
        public string FECHA_ALT { get; set; }
        public int SALARIO { get; set; }
        public int COMISION { get; set; }
        public int DEPT_NO { get; set; }
    }
}
