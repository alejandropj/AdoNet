using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNet.Helpers;

namespace AdoNet.Repositories
{
    public class RepositoryEmpleadoHospital
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryEmpleadoHospital()
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
                hospitales.Add(this.reader["NOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }
       /* public ResumenEmpleadoHospital GetResumenEmpleado(string nombreHospital)
        {
            return new ResumenEmpleado();
*//*            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombreHospital);
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
            ResumenEmpleadoHospital resumenEmpleadoHospital = new ResumenEmpleadoHospital();
            //resumenEmpleado.Apellidos = new List<string>();
            while (this.reader.Read())
            {
                resumenEmpleado.Apellidos.Add(this.reader["APELLIDO"].ToString());
            }

            this.reader.Close();
            int suma = 0;
            int media = 0;
            if (resumenEmpleado.Apellidos.Count != 0)
            {
                suma = int.Parse(pamSuma.Value.ToString());
                media = int.Parse(pamMedia.Value.ToString());
            }

            resumenEmpleado.SumaSalarial = suma;
            resumenEmpleado.MediaSalarial = media;
            resumenEmpleado.Personas = int.Parse(pamPersonas.Value.ToString());

            this.cn.Close();
            this.com.Parameters.Clear();
            return resumenEmpleado;*//*
        }*/
    }
}
