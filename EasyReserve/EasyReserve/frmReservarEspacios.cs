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
    public partial class frmReservarEspacios : Form
    {
        public frmReservarEspacios()
        {
            InitializeComponent();
        }

        private void btnSconferencia_Click(object sender, EventArgs e)
        {
            frmSalaConferencia reservaSalaConferencia = new frmSalaConferencia();
            reservaSalaConferencia.Show();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            frmAulas reservaAulas = new frmAulas();
            reservaAulas.Show();
        }

        private void btnCanchas_Click(object sender, EventArgs e)
        {

            frmCanchas reservaCanchas = new frmCanchas();
            reservaCanchas.Show();
        }

        private void btnGimnasios_Click(object sender, EventArgs e)
        {

            frmGimnasios reservaGimnasios = new frmGimnasios();
            reservaGimnasios.Show();
        }
    }
}
