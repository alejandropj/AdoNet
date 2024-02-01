using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form12EmpleadosHospital : Form
    {
        RepositoryEmpleadosHospital repo;
        public Form12EmpleadosHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleadosHospital();
            List<string> hospitales = this.repo.GetHospitales();
            foreach (string hospital in hospitales)
            {
                this.cmbHospitales.Items.Add(hospital);

            }
        }

        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstEmpleados.Items.Clear();
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            DatosHospital datos = this.repo.GetDatosHospital(nombre);
            this.txtSuma.Text = datos.SumaSalarial.ToString();
            this.txtMedia.Text = datos.MediaSalarial.ToString();
            this.txtPersonas.Text = datos.Personas.ToString();
            foreach (EmpleadoHospital emp in datos.Empleados)
            {
                this.lstEmpleados.Items.Add(emp);
            }
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstEmpleados.SelectedIndex;
            if(index != -1)
            {
                EmpleadoHospital empleado = (EmpleadoHospital) this.lstEmpleados.SelectedItem;
                this.txtSalario.Text = empleado.Salario.ToString();
                this.txtOficio.Text = empleado.Oficio.ToString();
            }
        }
    }
}
