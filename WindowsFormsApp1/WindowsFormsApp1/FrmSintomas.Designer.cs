
namespace WindowsFormsApp1
{
    partial class FrmSintomas
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnGuardarRegistro = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.Sintoma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuracion1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSintomas = new System.Windows.Forms.ComboBox();
            this.txtOpcional = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.iconPictureBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBuscar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.gbDatos);
            this.panel3.Location = new System.Drawing.Point(386, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 557);
            this.panel3.TabIndex = 3;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnGuardarRegistro);
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Controls.Add(this.iconButtonAgregar);
            this.gbDatos.Controls.Add(this.dtgDatos);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtDuracion1);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.cmbSintomas);
            this.gbDatos.Controls.Add(this.txtOpcional);
            this.gbDatos.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(15, 11);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDatos.Size = new System.Drawing.Size(571, 550);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Registro de sintomas";
            this.gbDatos.Visible = false;
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarRegistro.IconColor = System.Drawing.Color.Black;
            this.btnGuardarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarRegistro.IconSize = 40;
            this.btnGuardarRegistro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarRegistro.Location = new System.Drawing.Point(419, 487);
            this.btnGuardarRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(57, 49);
            this.btnGuardarRegistro.TabIndex = 11;
            this.btnGuardarRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarRegistro.UseVisualStyleBackColor = true;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 40;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(482, 487);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(61, 49);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // iconButtonAgregar
            // 
            this.iconButtonAgregar.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAgregar.IconColor = System.Drawing.Color.Black;
            this.iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAgregar.IconSize = 40;
            this.iconButtonAgregar.Location = new System.Drawing.Point(463, 182);
            this.iconButtonAgregar.Name = "iconButtonAgregar";
            this.iconButtonAgregar.Size = new System.Drawing.Size(61, 49);
            this.iconButtonAgregar.TabIndex = 12;
            this.iconButtonAgregar.UseVisualStyleBackColor = false;
            this.iconButtonAgregar.Click += new System.EventHandler(this.iconButtonAgregar_Click);
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sintoma,
            this.Duracion});
            this.dtgDatos.Location = new System.Drawing.Point(25, 258);
            this.dtgDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.RowHeadersWidth = 62;
            this.dtgDatos.RowTemplate.Height = 28;
            this.dtgDatos.Size = new System.Drawing.Size(518, 225);
            this.dtgDatos.TabIndex = 11;
            // 
            // Sintoma
            // 
            this.Sintoma.HeaderText = "Sintoma";
            this.Sintoma.MinimumWidth = 8;
            this.Sintoma.Name = "Sintoma";
            this.Sintoma.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duración";
            this.Duracion.MinimumWidth = 8;
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duración (Días)";
            // 
            // txtDuracion1
            // 
            this.txtDuracion1.Location = new System.Drawing.Point(247, 134);
            this.txtDuracion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuracion1.Multiline = true;
            this.txtDuracion1.Name = "txtDuracion1";
            this.txtDuracion1.Size = new System.Drawing.Size(197, 40);
            this.txtDuracion1.TabIndex = 9;
            this.txtDuracion1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Otro(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sintomas comunes";
            // 
            // cmbSintomas
            // 
            this.cmbSintomas.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSintomas.FormattingEnabled = true;
            this.cmbSintomas.Location = new System.Drawing.Point(247, 84);
            this.cmbSintomas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSintomas.Name = "cmbSintomas";
            this.cmbSintomas.Size = new System.Drawing.Size(197, 39);
            this.cmbSintomas.TabIndex = 2;
            // 
            // txtOpcional
            // 
            this.txtOpcional.Location = new System.Drawing.Point(247, 191);
            this.txtOpcional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpcional.Multiline = true;
            this.txtOpcional.Name = "txtOpcional";
            this.txtOpcional.Size = new System.Drawing.Size(197, 31);
            this.txtOpcional.TabIndex = 1;
            this.txtOpcional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpcional_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 99);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "GESTION DE SINTOMAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iconPictureBuscar);
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtProvincia);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCedula);
            this.groupBox2.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(374, 550);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(119, 84);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedula.MaxLength = 9;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(192, 39);
            this.txtCedula.TabIndex = 11;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cédula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Provincia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 183);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(206, 39);
            this.txtNombre.TabIndex = 15;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(119, 279);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(206, 39);
            this.txtProvincia.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(119, 364);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(206, 39);
            this.txtEdad.TabIndex = 18;
            // 
            // iconPictureBuscar
            // 
            this.iconPictureBuscar.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBuscar.ForeColor = System.Drawing.Color.MediumBlue;
            this.iconPictureBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBuscar.IconColor = System.Drawing.Color.MediumBlue;
            this.iconPictureBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBuscar.IconSize = 40;
            this.iconPictureBuscar.Location = new System.Drawing.Point(327, 83);
            this.iconPictureBuscar.Name = "iconPictureBuscar";
            this.iconPictureBuscar.Size = new System.Drawing.Size(47, 40);
            this.iconPictureBuscar.TabIndex = 19;
            this.iconPictureBuscar.TabStop = false;
            this.iconPictureBuscar.Click += new System.EventHandler(this.iconPictureBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 557);
            this.panel2.TabIndex = 2;
            // 
            // FrmSintomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSintomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSintomas";
            this.panel3.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBuscar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSintomas;
        private System.Windows.Forms.TextBox txtOpcional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuracion1;
        private FontAwesome.Sharp.IconButton btnGuardarRegistro;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintoma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBuscar;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Panel panel2;
    }
}