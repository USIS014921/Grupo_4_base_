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
    public partial class Acess : Form
    {
        public OleDbConnection miconexion;
        public String usuario_modificar;
        private object sistemaDataSet;

        public Acess()
        {
            miconexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Proyecto.mdb");

            InitializeComponent();
        }

        private void Acess_Load(object sender, EventArgs e)
        {
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            this.proyectoTableAdapter.Fill(this.proyectoDataSet.Proyecto);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bprimero_Click(object sender, EventArgs e)
        {
            this.proyectoBindingSource.MoveFirst();
        }

        private void lstnivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.proyectoBindingSource.MovePrevious();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.proyectoBindingSource.MoveNext();
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.proyectoBindingSource.MoveLast();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione el Nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;

        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    OleDbCommand guardar = new OleDbCommand();
                    miconexion.Open();
                    guardar.Connection = miconexion;
                    guardar.CommandType = CommandType.Text;
                    guardar.CommandText = "INSERT INTO Proyecto ([nombre], [clave],[nivel]) Values('" + txtusuario.Text.ToString() + "','" + txtclave.Text.ToString() + "','" + lstnivel.Text.ToString() + "')";
                    guardar.ExecuteNonQuery();
                    miconexion.Close();
                    bnuevo.Visible = true;
                    bguardar.Visible = false;
                    txtusuario.Enabled = false;
                    txtclave.Enabled = false;
                    lstnivel.Enabled = false;
                    bnuevo.Focus();
                    MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.proyectoTableAdapter.Fill(this.sistemaDataSet.proyecto);
                    this.proyectoBindingSource.MoveLast();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;
            usuario_modificar = txtusuario.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;
                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;

                actualizar.CommandText = "UPDATE Proyecto SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

                //actualizar.CommandText = "UPDATE Proyecto set nombre = '" + nom + "' WERE nombre = '" + usuario_modificar + "'";
                //actualizar.CommandText = "UPDATE Proyecto set clave = '" + cla + "' WERE nombre = '" + usuario_modificar + "'";
                //actualizar.CommandText = "UPDATE Proyecto set nivel = '" + niv + "' WERE nombre = '" + usuario_modificar + "'";
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                bmodificar.Visible = true;
                bactualizar.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;


                MessageBox.Show("Usuario actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.proyectoTableAdapter.Fill(this.sistemaDataSet.);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open();
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text;
                eliminar.CommandText = "DELETE FROM Proyecto WHERE nombre = '" + txtusuario.Text.ToString() + "'";
                eliminar.ExecuteNonQuery();
                this.proyectoBindingSource.MoveNext();
                miconexion.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.proyectoTableAdapter.Fill(this.sistemaDataSet.Proyecto);
                this.proyectoBindingSource.MovePrevious();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bentrar_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection conexion_access = new OleDbConnection();


                conexion_access.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Proyecto.mdb";
                conexion_access.Open();

                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM Proyecto", conexion_access);
                //OleDbDataReader reader = command.ExecuteReader();
                DataSet resultado = new DataSet();
                consulta.Fill(resultado);
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if ((txtusuario.Text == registro["nombre"].ToString()) && (txtclave.Text == registro["clave"].ToString()))
                    {

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();
            }

            miconexion.Close();
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    } 
}