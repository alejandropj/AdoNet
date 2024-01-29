using System.Data;
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            //texto\\texto2
            //@"texto\texto2"
            this.connectionString = @"Data Source=ALE-PC\SQLEXPRESS;User ID=sa;Password=MCSD2023;Connect Timeout=30;Encrypt=True";
            this.cn = new SqlConnection(this.connectionString);
            //Vamos a recuperar un evento de la conexion para que nos
            //indique su cambio de estado
            this.cn.StateChange += Cn_StateChange;
            this.com = new SqlCommand();

        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexión está pasando de " + e.OriginalState +
                " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //this.cn.ConnectionString = this.connectionString;
            //Podemos capturar la excepción con try catch
            try
            {
                if (this.cn.State == System.Data.ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                this.lblMensaje.BackColor = Color.LightGreen;

            }
            catch(SqlException ex)
            {
                this.lblMensaje.Text = "Excepción SQL. " + ex.ToString();
                    this.lblMensaje.BackColor = Color.Red;
            }

        }
        private void btnDesconnect_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.LightCoral;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            this.com.Connection = this.cn;
            string sql = "select * from EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.reader = this.com.ExecuteReader();
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
            }

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            this.reader.Close();
        }
    }
}
