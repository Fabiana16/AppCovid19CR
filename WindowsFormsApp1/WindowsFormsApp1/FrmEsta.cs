using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmEsta : Form
    {
        Conexion conexion;
        public FrmEsta()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.ObtenerStringConexion());

            this.comboBoxOpcEstadistica.Items.Add("Por género");
            this.comboBoxOpcEstadistica.Items.Add("Por provincia");
            this.comboBoxOpcEstadistica.Items.Add("Por nacionalidad");
            this.comboBoxOpcEstadistica.Items.Add("Pacientes asintomáticos");
            this.comboBoxOpcEstadistica.Items.Add("Por edad");
        }

        public void cargarDatos()
        {
            chartGenero.Series[0].Points.DataBindXY(conexion.graficoGeneroPrueba(), conexion.graficoGeneroPrueba2());
            chartProvincia.Series[0].Points.DataBindXY(conexion.graficoCantSintomasProvincia(), conexion.graficoCantSintomasProvincia2());
        }

        private void FrmEsta_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void comboBoxOpcEstadistica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxOpcEstadistica.SelectedIndex == 0)
            {
                chartGenero.Visible = true;
            }
            if (comboBoxOpcEstadistica.SelectedIndex == 1)
            {
                chartProvincia.Visible = true;
            }
        }
    }
}
