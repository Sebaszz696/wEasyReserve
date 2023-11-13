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
    public partial class frmReservarEspacio : Form
    {
        public frmReservarEspacio()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server=SEBASZZ ; database = dboEasyReserve; INTEGRATED SECURITY = true");
        private void cboTipoDeEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {



            if ((cboTipoDeEspacio.Text == "Cancha de futbol"))
            {
                    
                cboEscenario.Items.Clear();
                cboEscenario.Items.AddRange(new object[] {
                "Cintetica",
                "Salon"});

            }
            else if ((cboTipoDeEspacio.Text == "Cancha de baloncesto"))
            {

                cboEscenario.Items.Clear();
                cboEscenario.Items.AddRange(new object[] {
                "Profesional",
                "Aire libre"});

            }
            else if ((cboTipoDeEspacio.Text == "Gimnasio"))
            {

                cboEscenario.Items.Clear();
                cboEscenario.Items.AddRange(new object[] {
                "Crossfit",
                "Estandar",
                "Recuperacio"});

            }
            else if ((cboTipoDeEspacio.Text == "Salas de conferencia"))
            {

                cboEscenario.Items.Clear();
                cboEscenario.Items.AddRange(new object[] {
                "Sala A",
                "Sala B",
                "Sala C"});

            }
            else if ((cboTipoDeEspacio.Text == "Aulas"))
            {

                cboEscenario.Items.Clear();
                cboEscenario.Items.AddRange(new object[] {
                "Aula 1",
                "Aula 2",
                "Aula 3"});

            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservarEspacioCrud ReservarEspacioCrud = new frmReservarEspacioCrud();
            ReservarEspacioCrud.Show();
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {


            // Obtener la fecha seleccionada del control MonthCalendar
            DateTime fechaSeleccionada = mcFecha.SelectionRange.Start;

            // Obtener la hora seleccionada del control ComboBox
            string horaSeleccionada = cboHora.SelectedItem.ToString();

            // Obtener el tipo de espacio seleccionado del control ComboBox
            string tipoEspacioSeleccionado = cboTipoDeEspacio.SelectedItem.ToString();

            // Obtener el escenario seleccionado del control ComboBox
            string escenarioSeleccionado = cboEscenario.SelectedItem.ToString();

            int TuCedula = Convert.ToInt32(txtTuCedula.Text);
            // Preparar la consulta SQL para insertar los datos en la tabla
            string consultaSQL = "INSERT INTO tblReservarEspacio (cmFecha, strHora, strTipoEspacio, strEscenario, strTuCedula) " +
                                 "VALUES (@Fecha, @Hora, @TipoEspacio, @Escenario, @TuCedula)";

            // Crear una instancia de SqlCommand y asociarla a la conexión
            using (SqlCommand comando = new SqlCommand(consultaSQL, coneccion))
            {
                // Asignar los valores a los parámetros de la consulta SQL
                comando.Parameters.AddWithValue("@Fecha", fechaSeleccionada);
                comando.Parameters.AddWithValue("@Hora", horaSeleccionada);
                comando.Parameters.AddWithValue("@TipoEspacio", tipoEspacioSeleccionado);
                comando.Parameters.AddWithValue("@Escenario", escenarioSeleccionado);
                comando.Parameters.AddWithValue("@TuCedula", TuCedula);

                try
                {
                    // Abrir la conexión a la base de datos
                    coneccion.Open();

                    // Ejecutar la consulta SQL
                    comando.ExecuteNonQuery();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Espacio reservado con éxito. Volverás a la pantalla principal.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir durante la ejecución de la consulta
                    MessageBox.Show($"Error al reservar el espacio: {ex.Message}");
                }
                finally
                {
                    // Cerrar la conexión a la base de datos
                    coneccion.Close();
                }
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID de espacio desde el control TextBox
                int IDespacio = Convert.ToInt32(txtIDespacio.Text);

                // Verificar si el campo está vacío

                {
                    // Mostrar un mensaje de error o realizar alguna acción
                    MessageBox.Show("El campo IDespacio no puede estar vacío.", "Error de validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Detener el envío del formulario
                    return;
                }


                // Obtener la fecha seleccionada del control MonthCalendar
                DateTime fechaSeleccionada = mcFecha.SelectionRange.Start;

                // Obtener la hora seleccionada del control ComboBox
                string horaSeleccionada = cboHora.SelectedItem.ToString();

                // Obtener el tipo de espacio seleccionado del control ComboBox
                string tipoEspacioSeleccionado = cboTipoDeEspacio.SelectedItem.ToString();

                // Obtener el escenario seleccionado del control ComboBox
                string escenarioSeleccionado = cboEscenario.SelectedItem.ToString();

                int tuCedula = Convert.ToInt32(txtTuCedula.Text);

                // Preparar la consulta SQL para actualizar los datos en la tabla
                string consultaSQL = "UPDATE tblReservarEspacio " +
                                     "SET cmFecha = @Fecha, strHora = @Hora, strTipoEspacio = @TipoEspacio, " +
                                     "strEscenario = @Escenario, strTuCedula = @TuCedula " +
                                     "WHERE IDespacio = @IDespacio";

                // Crear una instancia de SqlCommand y asociarla a la conexión
                using (SqlCommand comando = new SqlCommand(consultaSQL, coneccion))
                {
                    // Asignar los valores a los parámetros de la consulta SQL
                    comando.Parameters.AddWithValue("@IDespacio", IDespacio);
                    comando.Parameters.AddWithValue("@Fecha", fechaSeleccionada);
                    comando.Parameters.AddWithValue("@Hora", horaSeleccionada);
                    comando.Parameters.AddWithValue("@TipoEspacio", tipoEspacioSeleccionado);
                    comando.Parameters.AddWithValue("@Escenario", escenarioSeleccionado);
                    comando.Parameters.AddWithValue("@TuCedula", tuCedula);

                    try
                    {
                        // Abrir la conexión a la base de datos
                        coneccion.Open();

                        // Ejecutar la consulta SQL
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            // Mostrar mensaje de éxito
                            MessageBox.Show("Reserva de espacio modificada con éxito. Volverás a la pantalla principal.");
                            this.Close();
                        }
                        else
                        {
                            // Mostrar mensaje si no se encontró la reserva con el ID proporcionado
                            MessageBox.Show("No se encontró ninguna reserva con el ID proporcionado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que pueda ocurrir durante la ejecución de la consulta
                        MessageBox.Show($"Error al modificar el espacio: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión a la base de datos
                        coneccion.Close();
                    }
                }
            
            }
            catch (Exception)
            {
                MessageBox.Show("Revisa si estas poniendo todos los datos o si el cajon inferior no esta vacio");
                
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cboHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mcFecha_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtTuCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboEscenario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
