using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyReserve
{
    public partial class frmReservarEspecialistaCrud : Form
    {
        public frmReservarEspecialistaCrud()
        {
            InitializeComponent();

        }
        SqlConnection coneccion = new SqlConnection("server=SEBASZZ ; database = dboEasyReserve; INTEGRATED SECURITY = true");




        // Botón para consultar reservas
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cédula ingresada por el usuario
                int cedula = Convert.ToInt32(txtTuCedula.Text);

                // Crear una instancia de la clase clsRegistro
                clsRegistro registro = new clsRegistro();

                // Consultar datos por cédula
                DataTable resultadoConsulta = registro.consultarDatosPorCedula(cedula);

                // Mostrar los resultados en un DataGridView
                dtgCliente.DataSource = resultadoConsulta;

                // Opcional: Limpiar la caja de texto de cédula después de la consulta
                txtTuCedula.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar datos: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión si es necesario
                // Esto puede ir en el destructor o en otro evento según tus necesidades
                // registro.cerrarConexion();
            }
        }





        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cédula ingresada por el usuario
                int IDcita = Convert.ToInt32(txtIDcita.Text);

                // Crear una instancia de la clase clsRegistro
                clsRegistro registro = new clsRegistro();

                // Eliminar datos por cédula
                registro.eliminarDatosPorIDcita(IDcita);

                //  Limpiar la caja de texto de cédula después de la eliminación
                txtIDcita.Clear();

                //  Mostrar un mensaje indicando que la eliminación fue exitosa
                MessageBox.Show("Datos eliminados correctamente.");

  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar datos: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
