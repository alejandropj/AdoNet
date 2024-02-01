using AdoNet.Helpers;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryParametrosSalida
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryParametrosSalida()
        {
            string connectionString = HelperConfigurations.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<string> GetDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> departamentos = new List<string>();
            while (this.reader.Read())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }
        public ResumenEmpleado GetResumenEmpleado(string nombreDept)
        {
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombreDept);
            //Pam de salida no lleva valor, sino que lo recuperamos del proc
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.Value = 0;
            pamSuma.ParameterName = "@SUMA";
            pamSuma.Direction = ParameterDirection.Output;
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.Value = 0;
            pamMedia.ParameterName = "@MEDIA";
            pamMedia.Direction = ParameterDirection.Output;
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.Value = 0;
            pamPersonas.ParameterName = "@PERSONAS";
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamSuma);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_DEPARTAMENTO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            ResumenEmpleado resumenEmpleado = new ResumenEmpleado();
            //resumenEmpleado.Apellidos = new List<string>();
            while (this.reader.Read())
            {
                resumenEmpleado.Apellidos.Add(this.reader["APELLIDO"].ToString());
            }

            this.reader.Close();
            int suma = 0;
            int media = 0;
            if(resumenEmpleado.Apellidos.Count != 0)
            {
                suma = int.Parse(pamSuma.Value.ToString());
                media = int.Parse(pamMedia.Value.ToString());
            }

            resumenEmpleado.SumaSalarial = suma;
            resumenEmpleado.MediaSalarial = media;
            resumenEmpleado.Personas = int.Parse(pamPersonas.Value.ToString());

            this.cn.Close();
            this.com.Parameters.Clear();
            return resumenEmpleado;
        }
    }
}
