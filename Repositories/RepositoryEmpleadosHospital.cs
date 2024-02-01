using AdoNet.Helpers;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region PROCEDIMIENTOS VISTAS SQL
/*ALTER VIEW V_DOCTORES_PLANTILLA
AS
	SELECT DOCTOR_NO AS IDEMPLEADO, APELLIDO, SALARIO, HOSPITAL_COD FROM DOCTOR 
	UNION
	SELECT EMPLEADO_NO, APELLIDO, SALARIO, HOSPITAL_COD FROM PLANTILLA
GO
--SELECT * FROM V_DOCTORES_PLANTILLA

ALTER PROCEDURE SP_DOCTORES_PLANTILLA_HOSPITAL
(@NOMBRE NVARCHAR(50), @SUMA INT OUT, @MEDIA INT OUT, @PERSONAS INT OUT)
AS
	DECLARE @IDHOSPITAL INT
	SELECT @IDHOSPITAL = HOSPITAL_COD FROM HOSPITAL 
	WHERE NOMBRE = @NOMBRE

	SELECT * FROM V_DOCTORES_PLANTILLA
	WHERE HOSPITAL_COD = @IDHOSPITAL

	SELECT @SUMA = SUM(SALARIO), @MEDIA = AVG(SALARIO),
@PERSONAS = COUNT(IDEMPLEADO)
	FROM V_DOCTORES_PLANTILLA
	WHERE HOSPITAL_COD = @IDHOSPITAL
GO*/

#endregion

namespace AdoNet.Repositories
{
    public class RepositoryEmpleadosHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryEmpleadosHospital()
        {
            string connectionString = HelperConfigurations.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> hospitales = new List<string>();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public DatosHospital GetDatosHospital (string nombreHospital)
        {
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombreHospital);
            SqlParameter pamSuma = new SqlParameter("@SUMA", 0);
            pamSuma.Direction = ParameterDirection.Output;
            SqlParameter pamMedia = new SqlParameter("@MEDIA", 0);
            pamMedia.Direction = ParameterDirection.Output;
            SqlParameter pamPersonas = new SqlParameter("@PERSONAS", 0);
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamSuma);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DOCTORES_PLANTILLA_HOSPITAL";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<EmpleadoHospital> empleados = new List<EmpleadoHospital>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["IDEMPLEADO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                string oficio = this.reader["OFICIO"].ToString();
                EmpleadoHospital empleado = new EmpleadoHospital();
                empleado.IdEmpleado = id;
                empleado.Apellido = apellido;
                empleado.Salario = salario;
                empleado.Oficio = oficio;
                empleados.Add(empleado);
            }
            this.reader.Close();
            int suma = int.Parse(pamSuma.Value.ToString());
            int media = int.Parse(pamMedia.Value.ToString());
            int personas = int.Parse(pamPersonas.Value.ToString());
            this.cn.Close();
            this.com.Parameters.Clear();
            DatosHospital datos = new DatosHospital();
            datos.Empleados = empleados;
            datos.SumaSalarial = suma;
            datos.MediaSalarial = media;
            datos.Personas = personas;
            
            return datos;
        }

    }
}
