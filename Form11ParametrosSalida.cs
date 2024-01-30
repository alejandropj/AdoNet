using AdoNet.Models;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdoNet
{
    #region PROCEDIMIENTOS ALMACENADOS
    //    CREATE PROCEDURE SP_EMPLEADOS_DEPARTAMENTO
    //(@NOMBRE NVARCHAR(50),
    //@SUMA INT OUT,
    //@MEDIA INT OUT,
    //@PERSONAS INT OUT)
    //AS
    //    DECLARE @IDDEPARTAMENTO INT


    //    SELECT @IDDEPARTAMENTO = DEPT_NO FROM DEPT

    //    WHERE DNOMBRE = @NOMBRE


    //    SELECT* FROM EMP WHERE DEPT_NO = @IDDEPARTAMENTO
    //    SELECT @SUMA = SUM(SALARIO),@MEDIA=AVG(SALARIO),
    //	@PERSONAS = COUNT(EMP_NO) FROM EMP

    //    WHERE DEPT_NO = @IDDEPARTAMENTO



    //GO
    #endregion
    public partial class Form11ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form11ParametrosSalida()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();

        }
        private void LoadDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbDept.Items.Add(this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombreDept = this.cmbDept.SelectedItem.ToString();
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombreDept);
            //Pam de salida no lleva valor, sino que lo recuperamos del proc
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@SUMA";
            pamSuma.Direction = ParameterDirection.Output;            
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@MEDIA";
            pamMedia.Direction = ParameterDirection.Output;            
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@PERSONAS";
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_DEPARTAMENTO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                this.lstEmpleados.Items.Add(this.reader["APELLIDO"].ToString());
            }
            this.txtSuma.Text = pamSuma.Value.ToString();
            this.txtMedia.Text = pamMedia.Value.ToString();
            this.txtPersonas.Text = pamPersonas.Value.ToString();
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
