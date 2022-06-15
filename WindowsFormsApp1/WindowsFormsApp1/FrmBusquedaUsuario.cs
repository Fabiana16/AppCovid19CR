using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace WindowsFormsApp1
{
    public partial class FrmBusquedaUsuario : Form
    {
        private Conexion conexion;
        public FrmBusquedaUsuario()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.ObtenerStringConexion());
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario frm = new FrmAgregarUsuario();
            frm.ShowDialog();
            frm.Dispose();
        }
        //Método encargado de consultar los usuarios del sistema por su login
        public void consultarUsuarios(string login)
        {
            try
            {
                this.dtgDatos.DataSource = this.conexion.BuscarUsuarioLogin(login).Tables[0];
                this.dtgDatos.AutoResizeColumns();
                this.dtgDatos.ReadOnly = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }// fin del método consultarUsuarios

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            this.consultarUsuarios(this.txtLogin.Text.Trim());
        }
    }
}
