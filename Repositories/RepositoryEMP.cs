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
        public List<Empleado> GetEmpleados()
        {
            string sql = "select * from EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Empleado> empleados = new List<Empleado>();
            while (this.reader.Read())
            {
                int emp_no = int.Parse(this.reader["EMP_NO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                int dir = int.Parse(this.reader["DIR"].ToString());
                string fecha_alt = this.reader["FECHA_ALT"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                int comision = int.Parse(this.reader["COMISION"].ToString());
                int dept_no = int.Parse(this.reader["DEPT_NO"].ToString());

                Empleado emp = new Empleado();
                emp.EMP_NO = emp_no;
                emp.APELLIDO = apellido;
                emp.OFICIO = oficio;
                emp.DIR = dir;
                emp.FECHA_ALT = fecha_alt;
                emp.SALARIO = salario;
                emp.COMISION = comision;
                emp.DEPT_NO = dept_no;
                empleados.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            return empleados;
        }
        public List<String> GetOficiosEmpleados()
        {
            string sql = "select OFICIOS from EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<String> oficios = new List<System.String>();
            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            this.reader.Close();
            this.cn.Close();
            return oficios;
        }

        public List<EmpSalario> FindEmpleadosByOficio(string oficio)
        {
            string sql = "select apellido,sum(salario) as SUMATORIO from DEPT where oficio=@oficio group by apellido";
            SqlParameter pamId = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();


            List<EmpSalario> empleadosSalario = new List<EmpSalario>();
            while (this.reader.Read())
            {
                int salarioTotal = int.Parse(this.reader["SUMATORIO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();

                EmpSalario empSalario = new EmpSalario();
                empSalario.salarioTotal = salarioTotal;
                empSalario.apellido = apellido;
                empleadosSalario.Add(empSalario);
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return empleadosSalario;
        }

        public int InsertarEmpleado(int id, string nombre, string localidad)
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
        public int ModificarEmpleado(int id, string nombre, string localidad)
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

    }
}
