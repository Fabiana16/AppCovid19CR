
namespace WindowsFormsApp1
{
    partial class FrmEstadistica
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgDatosComunes = new System.Windows.Forms.DataGridView();
            this.dtgDatosDuracion = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgDatosCantGenero = new System.Windows.Forms.DataGridView();
            this.dtgDatosCantProvincia = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosComunes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosDuracion)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosCantGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosCantProvincia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.ptbSalir);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 100);
            this.panel1.TabIndex = 1;
            // 
            // ptbSalir
            // 
            this.ptbSalir.Image = global::WindowsFormsApp1.Properties.Resources._16__Db_cancel_;
            this.ptbSalir.Location = new System.Drawing.Point(868, 3);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(47, 38);
            this.ptbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSalir.TabIndex = 0;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtgDatosComunes);
            this.panel2.Controls.Add(this.dtgDatosDuracion);
            this.panel2.Location = new System.Drawing.Point(6, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 485);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sintomas más comunes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Promedio de duración de los síntomas";
            // 
            // dtgDatosComunes
            // 
            this.dtgDatosComunes.AllowUserToAddRows = false;
            this.dtgDatosComunes.AllowUserToDeleteRows = false;
            this.dtgDatosComunes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatosComunes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosComunes.Location = new System.Drawing.Point(6, 247);
            this.dtgDatosComunes.Name = "dtgDatosComunes";
            this.dtgDatosComunes.ReadOnly = true;
            this.dtgDatosComunes.RowHeadersWidth = 62;
            this.dtgDatosComunes.RowTemplate.Height = 28;
            this.dtgDatosComunes.Size = new System.Drawing.Size(556, 150);
            this.dtgDatosComunes.TabIndex = 1;
            // 
            // dtgDatosDuracion
            // 
            this.dtgDatosDuracion.AllowUserToAddRows = false;
            this.dtgDatosDuracion.AllowUserToDeleteRows = false;
            this.dtgDatosDuracion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatosDuracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosDuracion.Location = new System.Drawing.Point(3, 53);
            this.dtgDatosDuracion.Name = "dtgDatosDuracion";
            this.dtgDatosDuracion.ReadOnly = true;
            this.dtgDatosDuracion.RowHeadersWidth = 62;
            this.dtgDatosDuracion.RowTemplate.Height = 28;
            this.dtgDatosDuracion.Size = new System.Drawing.Size(559, 150);
            this.dtgDatosDuracion.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtgDatosCantGenero);
            this.panel3.Controls.Add(this.dtgDatosCantProvincia);
            this.panel3.Location = new System.Drawing.Point(601, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 485);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad de casos-provincia";
            // 
            // dtgDatosCantGenero
            // 
            this.dtgDatosCantGenero.AllowUserToAddRows = false;
            this.dtgDatosCantGenero.AllowUserToDeleteRows = false;
            this.dtgDatosCantGenero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatosCantGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosCantGenero.Location = new System.Drawing.Point(8, 247);
            this.dtgDatosCantGenero.Name = "dtgDatosCantGenero";
            this.dtgDatosCantGenero.ReadOnly = true;
            this.dtgDatosCantGenero.RowHeadersWidth = 62;
            this.dtgDatosCantGenero.RowTemplate.Height = 28;
            this.dtgDatosCantGenero.Size = new System.Drawing.Size(302, 150);
            this.dtgDatosCantGenero.TabIndex = 5;
            // 
            // dtgDatosCantProvincia
            // 
            this.dtgDatosCantProvincia.AllowUserToAddRows = false;
            this.dtgDatosCantProvincia.AllowUserToDeleteRows = false;
            this.dtgDatosCantProvincia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatosCantProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosCantProvincia.Location = new System.Drawing.Point(8, 53);
            this.dtgDatosCantProvincia.Name = "dtgDatosCantProvincia";
            this.dtgDatosCantProvincia.ReadOnly = true;
            this.dtgDatosCantProvincia.RowHeadersWidth = 62;
            this.dtgDatosCantProvincia.RowTemplate.Height = 28;
            this.dtgDatosCantProvincia.Size = new System.Drawing.Size(302, 150);
            this.dtgDatosCantProvincia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de casos por género";
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstadistica";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosComunes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosDuracion)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosCantGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosCantProvincia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgDatosComunes;
        private System.Windows.Forms.DataGridView dtgDatosDuracion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgDatosCantGenero;
        private System.Windows.Forms.DataGridView dtgDatosCantProvincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}