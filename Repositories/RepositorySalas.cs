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
    public class RepositorySalas
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositorySalas()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<Sala> GetSalas()
        {
            string sql = "select * from SALA";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Sala> salas = new List<Sala>();
            while (this.reader.Read())
            {
                string hospital_cod = this.reader["HOSPITAL_COD"].ToString();
                string sala_cod = this.reader["SALA_COD"].ToString();
                string nombre = this.reader["NOMBRE"].ToString();
                string num_cama = this.reader["NUM_CAMA"].ToString();
                Sala sala = new Sala();
                sala.HOSPITAL_COD = hospital_cod;
                sala.SALA_COD = sala_cod;
                sala.NOMBRE = nombre;
                sala.NUM_CAMA = num_cama;
                salas.Add(sala);
            }
            this.reader.Close();
            this.cn.Close();
            return salas;
        }

        public Sala FindSala
            (int idDept)
        {
            string sql = "select * from DEPT where DEPT_NO=@id";
            SqlParameter pamId = new SqlParameter("@ID", idDept);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            int id = int.Parse(this.reader["DEPT_NO"].ToString());
            string nombre = this.reader["DNOMBRE"].ToString();
            string loc = this.reader["LOC"].ToString();

            Departamento dept = new Departamento();
            dept.IdDepartmaento = id;
            dept.Nombre = nombre;
            dept.Localidad = loc;
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return dept;
        }

        public int InsertarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values(@id,@nombre,@localidad)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamLocalidad = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int results = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return results;
        }
        public int ModificarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "update DEPT set DNOMBRE=@nombre,LOC=@localidad where DEPT_NO=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamLocalidad = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int results = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return results;
        }
        public int EliminarDepartamento(int id)
        {
            string sql = "delete from DEPT where dept_no=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            this.com.Parameters.Add(pamId);
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
