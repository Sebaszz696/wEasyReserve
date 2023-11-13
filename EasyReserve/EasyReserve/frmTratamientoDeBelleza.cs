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
    public partial class frmTratamientoDeBelleza : Form
    {
        public frmTratamientoDeBelleza()
        {
            InitializeComponent();
        }
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {

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

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click_2(object sender, EventArgs e)
        {

        }
    }
}
