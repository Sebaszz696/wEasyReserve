using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyReserve
{
    public partial class frmCestetica : Form
    {
        public frmCestetica()
        {
            InitializeComponent();
        }




        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            // Minimizar el formulario al hacer clic en el botón "Minimizar"
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario al hacer clic en el botón "Cerrar"
            this.Close();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cita reservada con exito volveras a la pantalla principal.");
            this.Close();

        }
    }
}
