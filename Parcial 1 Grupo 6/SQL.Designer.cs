﻿
namespace Parcial_1_Grupo_6
{
    partial class SQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQL));
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bentrar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bprimero = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstnivel
            // 
            this.lstnivel.Enabled = false;
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.lstnivel.Location = new System.Drawing.Point(253, 111);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(100, 21);
            this.lstnivel.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // bentrar
            // 
            this.bentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bentrar.Location = new System.Drawing.Point(342, 287);
            this.bentrar.Name = "bentrar";
            this.bentrar.Size = new System.Drawing.Size(90, 33);
            this.bentrar.TabIndex = 54;
            this.bentrar.Text = "Entrar";
            this.bentrar.UseVisualStyleBackColor = true;
            this.bentrar.Click += new System.EventHandler(this.bentrar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.ForeColor = System.Drawing.Color.Black;
            this.bsalir.Location = new System.Drawing.Point(342, 233);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(90, 33);
            this.bsalir.TabIndex = 53;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            // 
            // bultimo
            // 
            this.bultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bultimo.ForeColor = System.Drawing.Color.Black;
            this.bultimo.Location = new System.Drawing.Point(342, 177);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(90, 33);
            this.bultimo.TabIndex = 52;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = true;
            // 
            // bactualizar
            // 
            this.bactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar.ForeColor = System.Drawing.Color.Black;
            this.bactualizar.Location = new System.Drawing.Point(231, 287);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(90, 33);
            this.bactualizar.TabIndex = 51;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            // 
            // bmodificar
            // 
            this.bmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar.ForeColor = System.Drawing.Color.Black;
            this.bmodificar.Location = new System.Drawing.Point(231, 233);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(90, 33);
            this.bmodificar.TabIndex = 50;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // bsiguiente
            // 
            this.bsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiguiente.ForeColor = System.Drawing.Color.Black;
            this.bsiguiente.Location = new System.Drawing.Point(231, 177);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(90, 33);
            this.bsiguiente.TabIndex = 49;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = true;
            // 
            // beliminar
            // 
            this.beliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.ForeColor = System.Drawing.Color.Black;
            this.beliminar.Location = new System.Drawing.Point(118, 233);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(90, 33);
            this.beliminar.TabIndex = 48;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            // 
            // banterior
            // 
            this.banterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior.ForeColor = System.Drawing.Color.Black;
            this.banterior.Location = new System.Drawing.Point(118, 177);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(90, 33);
            this.banterior.TabIndex = 47;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = true;
            this.banterior.Click += new System.EventHandler(this.banterior_Click);
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.ForeColor = System.Drawing.Color.Black;
            this.bguardar.Location = new System.Drawing.Point(9, 287);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(90, 33);
            this.bguardar.TabIndex = 46;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            // 
            // bnuevo
            // 
            this.bnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.ForeColor = System.Drawing.Color.Black;
            this.bnuevo.Location = new System.Drawing.Point(9, 233);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(90, 33);
            this.bnuevo.TabIndex = 45;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            // 
            // bprimero
            // 
            this.bprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprimero.ForeColor = System.Drawing.Color.Black;
            this.bprimero.Location = new System.Drawing.Point(9, 177);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(90, 33);
            this.bprimero.TabIndex = 44;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = true;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(253, 65);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(100, 20);
            this.txtclave.TabIndex = 43;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(253, 18);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(170, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(170, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(170, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(497, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 306);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1000, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bentrar);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bactualizar);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "SQL";
            this.Text = "Login con SQL";
            this.Load += new System.EventHandler(this.SQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bentrar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}