using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Parcial_1_Grupo_6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String usuario1 = "administrador";
            string clave1 = "admin";

            if (txtusuario.Text == usuario1 || txtclave.Text == clave1)
            {
             
                Form1 Form1 = new Form1();
                Form1.Show();
                this.Hide();
                
            }
            else MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtusuario.Text = "";
            txtclave.Text   = "";
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Acess acess = new Acess();
            acess.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            sql.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

