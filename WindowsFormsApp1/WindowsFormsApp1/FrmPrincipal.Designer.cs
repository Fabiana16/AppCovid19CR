
namespace WindowsFormsApp1
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FrmDashboard = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddRegistro = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAddPaci = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FrmDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrmDashboard
            // 
            this.FrmDashboard.BackColor = System.Drawing.Color.MidnightBlue;
            this.FrmDashboard.Controls.Add(this.iconButton2);
            this.FrmDashboard.Controls.Add(this.btnCerrarSesion);
            this.FrmDashboard.Controls.Add(this.pictureBox1);
            this.FrmDashboard.Controls.Add(this.btnAddRegistro);
            this.FrmDashboard.Controls.Add(this.iconButton1);
            this.FrmDashboard.Controls.Add(this.btnAddPaci);
            this.FrmDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.FrmDashboard.Location = new System.Drawing.Point(0, 0);
            this.FrmDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FrmDashboard.Name = "FrmDashboard";
            this.FrmDashboard.Size = new System.Drawing.Size(260, 851);
            this.FrmDashboard.TabIndex = 7;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 565);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(260, 65);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Usuarios";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrarSesion.IconSize = 40;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 786);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(260, 65);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_05_30_at_10_08_51_PM_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(11, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddRegistro
            // 
            this.btnAddRegistro.FlatAppearance.BorderSize = 0;
            this.btnAddRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRegistro.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRegistro.ForeColor = System.Drawing.Color.White;
            this.btnAddRegistro.IconChar = FontAwesome.Sharp.IconChar.Ambulance;
            this.btnAddRegistro.IconColor = System.Drawing.Color.White;
            this.btnAddRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddRegistro.IconSize = 40;
            this.btnAddRegistro.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddRegistro.Location = new System.Drawing.Point(3, 398);
            this.btnAddRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRegistro.Name = "btnAddRegistro";
            this.btnAddRegistro.Size = new System.Drawing.Size(256, 69);
            this.btnAddRegistro.TabIndex = 1;
            this.btnAddRegistro.Text = "Agregar Registro";
            this.btnAddRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRegistro.UseVisualStyleBackColor = true;
            this.btnAddRegistro.Click += new System.EventHandler(this.btnAddRegistro_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 482);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(260, 65);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Estadísticas ";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnAddPaci
            // 
            this.btnAddPaci.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPaci.FlatAppearance.BorderSize = 0;
            this.btnAddPaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPaci.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPaci.ForeColor = System.Drawing.Color.White;
            this.btnAddPaci.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.btnAddPaci.IconColor = System.Drawing.Color.White;
            this.btnAddPaci.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPaci.IconSize = 40;
            this.btnAddPaci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPaci.Location = new System.Drawing.Point(3, 319);
            this.btnAddPaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPaci.Name = "btnAddPaci";
            this.btnAddPaci.Size = new System.Drawing.Size(260, 74);
            this.btnAddPaci.TabIndex = 0;
            this.btnAddPaci.Text = "Agregar Paciente";
            this.btnAddPaci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPaci.UseVisualStyleBackColor = false;
            this.btnAddPaci.Click += new System.EventHandler(this.btnAddPaci_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_05_30_at_10_081;
            this.pictureBox2.Location = new System.Drawing.Point(259, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(675, 680);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.Lavender;
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Controls.Add(this.pictureBox2);
            this.panelFondo.Location = new System.Drawing.Point(260, 0);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1199, 848);
            this.panelFondo.TabIndex = 6;
            this.panelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmFondo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 851);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.FrmDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.FrmDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAddRegistro;
        private System.Windows.Forms.Panel FrmDashboard;
        private FontAwesome.Sharp.IconButton btnAddPaci;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Label label1;
    }
}

