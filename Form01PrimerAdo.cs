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
            this.connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            //Vamos a recuperar un evento de la conexion para que nos
            //indique su cambio de estado

            this.com = new SqlCommand();

        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            //this.cn.ConnectionString = this.connectionString;
            if (this.cn.State == System.Data.ConnectionState.Closed)
            {
                this.cn.Open();
            }
            this.lblMensaje.BackColor = Color.LightGreen;
        }
        private void btnDesconnect_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.LightCoral;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }
    }
}
