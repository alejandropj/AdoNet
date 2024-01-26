using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdoNet.Repositories
{
    public class RepositoryEMP
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryEMP()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<string> GetEmpleadosOficio(string oficio)
        {
            string sql = "select * from EMP where OFICIO=@oficio";
            SqlParameter pamOficio = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<string> apellidos = new List<string>();
            while (this.reader.Read())
            {
                apellidos.Add(this.reader["APELLIDO"].ToString());
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return apellidos;
        }
        public List<string> GetOficiosEmpleados()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<string> oficios = new List<string>();
            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            this.reader.Close();
            this.cn.Close();
            return oficios;
        }

        public DatosEmpleadosOficio DatosEmpleadosOficio(string oficio)
        {
            string sql = "select sum(salario) as SUMASALARIAL, AVG(salario) as MEDIASALARIAL, MIN(salario) as MINIMOSALARIO, OFICIO from EMP group by OFICIO having oficio=@oficio";
            SqlParameter pamOficio = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            int sumaSalarial = int.Parse(this.reader["SUMASALARIAL"].ToString());
            int mediaSalarial = int.Parse(this.reader["MEDIASALARIAL"].ToString());
            int minimoSalario = int.Parse(this.reader["MINIMOSALARIO"].ToString());

            DatosEmpleadosOficio datosEmp = new DatosEmpleadosOficio();
            datosEmp.SumaSalarial = sumaSalarial;
            datosEmp.MediaSalarial = mediaSalarial;
            datosEmp.MinimoSalario = minimoSalario;
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return datosEmp;
        }

        public int IncrementarSalarioOficio(string oficio, int incremento)
        {
            string sql = "update emp set SALARIO=SALARIO+@incremento where OFICIO=@oficio";
            SqlParameter pamOficio = new SqlParameter("@oficio", oficio);
            SqlParameter pamIncremento = new SqlParameter("@incremento", incremento);
            this.com.Parameters.Add(pamOficio);
            this.com.Parameters.Add(pamIncremento);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int results = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return results;
        }


    }
}
