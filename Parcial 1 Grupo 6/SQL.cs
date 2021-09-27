using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Parcial_1_Grupo_6
{
    public partial class SQL : Form
    {
        public SQL()
        {
            InitializeComponent();
        }

        static string conexion = "server = 127.0.0.1; port = 3306; database = conection; UID = root; password = ;";
        MySqlConnection cn = new MySqlConnection(conexion);

        private void bmodificar_Click(object sender, EventArgs e)
        {

        }

        private void banterior_Click(object sender, EventArgs e)
        {

        }

        private void SQL_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable ();
            String llenar = "Select * Form conection";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();

            return dt;
        }

        private void bentrar_Click(object sender, EventArgs e)
        {

        }

        private void bprimero_Click(object sender, EventArgs e)
        {
            
        }
    }
}
