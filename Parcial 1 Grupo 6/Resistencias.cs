﻿using System;
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
    public partial class Resistencias : Form
    {
        public Resistencias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades su compra se ha completado","Compra de Resistencia Pelicula Metalica",MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades su compra se ha completado", "Compra de Resistencia Pelicula de Carbon", MessageBoxButtons.OK);
        }

        private void Resistencias_Load(object sender, EventArgs e)
        {

        }
    }
}
