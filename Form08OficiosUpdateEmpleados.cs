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
    public partial class Form08OficiosUpdateEmpleados : Form
    {
        private RepositoryEMP repo;
        public Form08OficiosUpdateEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryEMP();
            List<string> oficioList = this.repo.GetOficiosEmpleados();
            foreach (string oficio in oficioList)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            //this.oficios = repo.GetOficiosEmpleados();
            int incremento = int.Parse(this.txtIncremento.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int result = this.repo.IncrementarSalarioOficio(oficio, incremento);
            DatosEmpleadosOficio datos = this.repo.DatosEmpleadosOficio(oficio);
            this.lblSuma.Text = "Suma salarial: " + datos.SumaSalarial;
            this.lblMedia.Text = "Media salarial: " + datos.MediaSalarial;
            this.lblMinimo.Text = "Minimo salarial: " + datos.MinimoSalario;
            MessageBox.Show("Actualizado: " + result);
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<string> apellidosList = this.repo.GetEmpleadosOficio(oficio);
                DatosEmpleadosOficio datos = this.repo.DatosEmpleadosOficio(oficio);
                this.lblSuma.Text = "Suma salarial: " + datos.SumaSalarial;
                this.lblMedia.Text = "Media salarial: " + datos.MediaSalarial;
                this.lblMinimo.Text = "Minimo salarial: " + datos.MinimoSalario;
                this.lstEmpleados.Items.Clear();
                foreach (string apellido in apellidosList)
                {
                    this.lstEmpleados.Items.Add(apellido);
                }
            }
        }
    }
}
