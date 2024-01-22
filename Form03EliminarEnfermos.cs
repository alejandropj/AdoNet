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
    public partial class Form03EliminarEnfermos : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermos()
        {

            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.LoadEnfermos();
        }
        private void LoadEnfermos()
        {
            string sql = "SELECT * FROM ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
 /*           string inscripcion = this.txtInscripcion.Text;
            string sql = "delete from ENFERMO where INSCRIPCION=" + inscripcion;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            MessageBox.Show("Enfermos eliminados " + eliminados);
            this.LoadEnfermos();*/

            string inscripcion = this.txtInscripcion.Text;
            string sql = "delete from ENFERMO where INSCRIPCION=@inscripcion";
            SqlParameter paminscripcion = new SqlParameter();
            paminscripcion.ParameterName = "@inscripcion";
            paminscripcion.DbType = DbType.Int32;
            paminscripcion.Value = inscripcion;
            paminscripcion.Direction = ParameterDirection.Input;
            this.com.Parameters.Add(paminscripcion);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Enfermos eliminados " + eliminados);
            this.LoadEnfermos();
        }
    }
}
