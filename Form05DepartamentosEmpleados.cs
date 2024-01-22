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
    public partial class Form05DepartamentosEmpleados : Form
    {
        int empNO;
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form05DepartamentosEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            string sql = "select * from dept";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["dnombre"].ToString();
                this.lstDepartamentos.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text.ToString();
            int salario = int.Parse(this.txtSalario.Text.ToString());

            string emp = this.lstEmpleados.SelectedItem.ToString();
            string sql = "update emp set oficio = '"+oficio+"', salario = "+salario +" where emp_no="+this.empNO;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int actualizados = this.com.ExecuteNonQuery();

            this.reader.Close();
            this.cn.Close();
            MessageBox.Show("Actualizados " + actualizados);

        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept = this.lstDepartamentos.SelectedItem.ToString();
            string sql = "select * from emp where dept_no = (select dept_no from dept where dnombre='" + dept + "')";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["apellido"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp = this.lstEmpleados.SelectedItem.ToString();
            string sql = "select * from emp where apellido = '" + emp + "'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.txtOficio.Text = "";
            this.txtSalario.Text = "";
            while (this.reader.Read())
            {
                this.empNO = int.Parse(this.reader["emp_no"].ToString());
                string oficio = this.reader["oficio"].ToString();
                string salario = this.reader["salario"].ToString();
                this.txtOficio.Text = oficio;
                this.txtSalario.Text = salario;
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
