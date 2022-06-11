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
    public partial class FrmEstadistica : Form
    {
        private Conexion conexion;
        public FrmEstadistica()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.ObtenerStringConexion());
            this.CargarPromedioSintomas();
            this.CargarSintomasComunes();
            this.CargarCantidadCasosProvincia();
            this.CargarTotalCasosGenero();
        }
        //Método que muestra la cantidad de casos totales por género
        public void CargarTotalCasosGenero()
        {
            try
            {
                this.dtgDatosCantGenero.DataSource = this.conexion.ConsultarCasosGenero().Tables[0];
                this.dtgDatosCantGenero.AutoResizeColumns();
                this.dtgDatosCantGenero.ReadOnly = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Método que carga los datos del promedio de sintomas
        public void CargarPromedioSintomas()
        {
            try
            {
                this.dtgDatosDuracion.DataSource = this.conexion.ConsultarPromedioSintomas().Tables[0];
                this.dtgDatosDuracion.AutoResizeColumns();
                this.dtgDatosDuracion.ReadOnly = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }//fin del método  CargarPromedioSintomas
        //Método para consutar la cantidad de casos por provincia
        public void CargarCantidadCasosProvincia()
        {
            try
            {
                this.dtgDatosCantProvincia.DataSource = this.conexion.ConsultarCasosProvincia().Tables[0];
                this.dtgDatosCantProvincia.AutoResizeColumns();
                this.dtgDatosCantProvincia.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Método que carga los sintomas mas comúnes de cada provincia
        public void CargarSintomasComunes()
        {
            try
            {
                this.dtgDatosComunes.DataSource = this.conexion.ConsultarDatosComunes().Tables[0];
                this.dtgDatosComunes.AutoResizeColumns();
                this.dtgDatosComunes.ReadOnly = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ptbSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
