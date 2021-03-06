﻿namespace MarcosMirandaTarea.Vista
{
    partial class frmIngresarNotasEst
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtvNotas = new System.Windows.Forms.DataGridView();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtIdMateria = new System.Windows.Forms.TextBox();
            this.txtIdEstudiante = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.lblIdEstudiante = new System.Windows.Forms.Label();
            this.IdNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstudiantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(556, 256);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(556, 199);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(556, 147);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtvNotas
            // 
            this.dtvNotas.AllowUserToAddRows = false;
            this.dtvNotas.AllowUserToDeleteRows = false;
            this.dtvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNotas,
            this.NombreEstudiante,
            this.NombreMateria,
            this.Nota,
            this.IDM,
            this.idEstudiantes});
            this.dtvNotas.Location = new System.Drawing.Point(50, 147);
            this.dtvNotas.Margin = new System.Windows.Forms.Padding(2);
            this.dtvNotas.Name = "dtvNotas";
            this.dtvNotas.ReadOnly = true;
            this.dtvNotas.RowHeadersWidth = 51;
            this.dtvNotas.RowTemplate.Height = 24;
            this.dtvNotas.Size = new System.Drawing.Size(465, 137);
            this.dtvNotas.TabIndex = 20;
            this.dtvNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvNotas_CellClick);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(392, 64);
            this.txtNota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(98, 20);
            this.txtNota.TabIndex = 19;
            // 
            // txtIdMateria
            // 
            this.txtIdMateria.Enabled = false;
            this.txtIdMateria.Location = new System.Drawing.Point(220, 64);
            this.txtIdMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMateria.Name = "txtIdMateria";
            this.txtIdMateria.Size = new System.Drawing.Size(101, 20);
            this.txtIdMateria.TabIndex = 18;
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.Enabled = false;
            this.txtIdEstudiante.Location = new System.Drawing.Point(50, 64);
            this.txtIdEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstudiante.TabIndex = 17;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(389, 37);
            this.lblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(40, 16);
            this.lblNota.TabIndex = 15;
            this.lblNota.Text = "Nota";
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMateria.Location = new System.Drawing.Point(217, 37);
            this.lblIdMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(78, 16);
            this.lblIdMateria.TabIndex = 14;
            this.lblIdMateria.Text = "Id Materia";
            // 
            // lblIdEstudiante
            // 
            this.lblIdEstudiante.AutoSize = true;
            this.lblIdEstudiante.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEstudiante.Location = new System.Drawing.Point(47, 37);
            this.lblIdEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdEstudiante.Name = "lblIdEstudiante";
            this.lblIdEstudiante.Size = new System.Drawing.Size(100, 16);
            this.lblIdEstudiante.TabIndex = 13;
            this.lblIdEstudiante.Text = "Id Estudiante";
            // 
            // IdNotas
            // 
            this.IdNotas.HeaderText = "IdNotas";
            this.IdNotas.MinimumWidth = 6;
            this.IdNotas.Name = "IdNotas";
            this.IdNotas.ReadOnly = true;
            // 
            // NombreEstudiante
            // 
            this.NombreEstudiante.HeaderText = "NombreEstudiante";
            this.NombreEstudiante.MinimumWidth = 6;
            this.NombreEstudiante.Name = "NombreEstudiante";
            this.NombreEstudiante.ReadOnly = true;
            // 
            // NombreMateria
            // 
            this.NombreMateria.HeaderText = "NombreMateria";
            this.NombreMateria.MinimumWidth = 6;
            this.NombreMateria.Name = "NombreMateria";
            this.NombreMateria.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // IDM
            // 
            this.IDM.HeaderText = "IDM";
            this.IDM.Name = "IDM";
            this.IDM.ReadOnly = true;
            this.IDM.Visible = false;
            // 
            // idEstudiantes
            // 
            this.idEstudiantes.HeaderText = "idEstudiantes";
            this.idEstudiantes.Name = "idEstudiantes";
            this.idEstudiantes.ReadOnly = true;
            this.idEstudiantes.Visible = false;
            // 
            // frmIngresarNotasEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 366);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtvNotas);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtIdMateria);
            this.Controls.Add(this.txtIdEstudiante);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblIdMateria);
            this.Controls.Add(this.lblIdEstudiante);
            this.Name = "frmIngresarNotasEst";
            this.Text = "frmIngresarNotasEst";
            this.Load += new System.EventHandler(this.frmIngresarNotasEst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtvNotas;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.TextBox txtIdEstudiante;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.Label lblIdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstudiantes;
    }
}