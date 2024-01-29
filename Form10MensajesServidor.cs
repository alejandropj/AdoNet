using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form10MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form10MensajesServidor()
        {
            InitializeComponent();
            this.lstDepartamentos.Items.Clear();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

            //CREAMOS UN EVENTO PARA CAPTURAR LOS MENSAJES DEL SERVER
            this.cn.InfoMessage += Cn_InfoMessage;
            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensajesServidor.Text = e.Message;
        }

        private void LoadDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                string dept = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(dept + " - " + nombre + " - " + loc);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensajesServidor.Text = "";
            int idDept = int.Parse(this.txtNumero.Text.ToString());
            string nombre = this.txtNombre.Text.ToString();
            string localidad = this.txtLocalidad.Text.ToString();
            SqlParameter pamId = new SqlParameter("@NUMERO", idDept);
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombre);
            SqlParameter pamLoc = new SqlParameter("@LOCALIDAD", localidad);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamLoc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_INSERT_DEPARTAMENTO";
            this.cn.Open();
            int insertados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Departamentos insertados: " + insertados);
            this.LoadDepartamentos();
        }
    }
}
