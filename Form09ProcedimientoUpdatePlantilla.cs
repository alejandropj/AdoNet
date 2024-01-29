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

#region PROCEDIMIENTOS ALMACENADOS
//        CREATE PROCEDURE SP_HOSPITALES
//AS

//    SELECT* FROM HOSPITAL
//GO
//CREATE PROCEDURE SP_UPDATE_PLANTILLA_HOSPITAL
//(@NOMBREHOSPITAL NVARCHAR(50))
//AS

//    DECLARE @CODIGOHOSPITAL INT

//    SELECT @CODIGOHOSPITAL= HOSPITAL_COD FROM HOSPITAL

//    WHERE NOMBRE = @NOMBREHOSPITAL


//    UPDATE PLANTILLA SET SALARIO = SALARIO +1

//    WHERE HOSPITAL_COD = @CODIGOHOSPITAL

//    SELECT* FROM PLANTILLA WHERE HOSPITAL_COD=@CODIGOHOSPITAL
//GO
#endregion
namespace AdoNet
{
    public partial class Form09ProcedimientoUpdatePlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form09ProcedimientoUpdatePlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbHospitales.Items.Add(this.reader["NOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            SqlParameter pamNombre = new SqlParameter("@NOMBREHOSPITAL", nombre);
            this.com.Parameters.Add(pamNombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_UPDATE_PLANTILLA_HOSPITAL";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " " + funcion + " " + salario);

            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
