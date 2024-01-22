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
    public partial class Form04ModificarSalas : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04ModificarSalas()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.LoadSalas();
        }
        private void LoadSalas()
        {
            string sql = "SELECT distinct NOMBRE FROM SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstModificar.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstModificar.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string sql = "update SALA set NOMBRE=@NEWSALA" + " where NOMBRE=@oldsala";
            string newsala = this.txtSala.Text;
            string oldsala = this.lstModificar.SelectedItem.ToString();
            SqlParameter pamoldsala = new SqlParameter("@oldsala", oldsala);
            SqlParameter pamnewsala = new SqlParameter("@NEWSALA", newsala);
            this.com.Parameters.Add(pamoldsala);
            this.com.Parameters.Add(pamnewsala);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Salas modificadas " + modificados);
            this.LoadSalas();
        }
    }
}
