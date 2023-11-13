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
    public partial class frmReservarEspecialista : Form
    {
        public frmReservarEspecialista()
        {
            InitializeComponent();
        }
        SqlConnection coneccion = new SqlConnection("server=SEBASZZ ; database = dboEasyReserve; INTEGRATED SECURITY = true");

        private void cboTipoDeCita_SelectedIndexChanged(object sender, EventArgs e)
        {


            if ((cboTipoDeCita.Text == "Psicología"))
            {

                cboEspecialista.Items.Clear();
                cboEspecialista.Items.AddRange(new object[] {
            "Psicologo Strange",
            "Psicologo Frankenstein"});

            }
            else if (cboTipoDeCita.Text == "Dermatología")
            {
                cboEspecialista.Items.Clear();
                cboEspecialista.Items.AddRange(new object[] {
                "Dermatologo Thor",
                "Dermatologo Tony"});
            }
            else if (cboTipoDeCita.Text == "Pediatría")
            {
                cboEspecialista.Items.Clear();
                cboEspecialista.Items.AddRange(new object[] {
                "Pediatra Peter",
                "Pediatra Jose"});
            }
            else if (cboTipoDeCita.Text == "Cirugia Estetica")
            {
                cboEspecialista.Items.Clear();
                cboEspecialista.Items.AddRange(new object[] {
                "Cirujano Estetico Amanda",
                "Cirujano Estetico Park"});
            }
            else if (cboTipoDeCita.Text == "Odontología")
            {
                cboEspecialista.Items.Clear();
                cboEspecialista.Items.AddRange(new object[] {
                "Odontologo Hulk",
                "Odontologo Patherson"});
            }
            else if (cboTipoDeCita.Text == "Ginecología")
            {
                cboEspecialista.Items.Clear();
                cboEspecialista.Items.AddRange(new object[] {
                "Ginecologo Samanta",
                "Ginecologo Sara"});
            }

        }




        private void cboEspecialista_SelectedIndexChanged(object sender, EventArgs e)
        {



        }




        private void txtTuCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmReservarEspecialistaCrud ReservarEspecialistaCrud = new frmReservarEspecialistaCrud();
            ReservarEspecialistaCrud.Show();
        }


        private void frmReservarEspacio_Load(object sender, EventArgs e)
        {

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID de cita desde el control TextBox
                int IDcita = Convert.ToInt32(txtIDcita.Text);

                // Obtener la fecha seleccionada del control MonthCalendar
                DateTime fechaSeleccionada = mcFecha.SelectionRange.Start;

                // Obtener la hora seleccionada del control ComboBox
                string horaSeleccionada = cboHora.SelectedItem.ToString();

                // Obtener el tipo de cita seleccionado del control ComboBox
                string tipoCitaSeleccionado = cboTipoDeCita.SelectedItem.ToString();

                // Obtener el especialista seleccionado del control ComboBox
                string especialistaSeleccionado = cboEspecialista.SelectedItem.ToString();

                int tuCedula = Convert.ToInt32(txtTuCedula.Text);

                // Preparar la consulta SQL para actualizar los datos en la tabla
                string consultaSQL = "UPDATE tblReservarEspecialista " +
                                     "SET cmFecha = @Fecha, strHora = @Hora, strTipoCita = @TipoCita, " +
                                     "strEspecialista = @Especialista, strTuCedula = @TuCedula " +
                                     "WHERE IDcita = @IDcita";

                // Crear una instancia de SqlCommand y asociarla a la conexión
                using (SqlCommand comando = new SqlCommand(consultaSQL, coneccion))
                {
                    // Asignar los valores a los parámetros de la consulta SQL
                    comando.Parameters.AddWithValue("@IDcita", IDcita);
                    comando.Parameters.AddWithValue("@Fecha", fechaSeleccionada);
                    comando.Parameters.AddWithValue("@Hora", horaSeleccionada);
                    comando.Parameters.AddWithValue("@TipoCita", tipoCitaSeleccionado);
                    comando.Parameters.AddWithValue("@Especialista", especialistaSeleccionado);
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
                            MessageBox.Show("Cita modificada con éxito. Volverás a la pantalla principal.");
                            this.Close();
                        }
                        else
                        {
                            // Mostrar mensaje si no se encontró la cita con el ID proporcionado
                            MessageBox.Show("No se encontró ninguna cita con el ID proporcionado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que pueda ocurrir durante la ejecución de la consulta
                        MessageBox.Show($"Error al modificar la cita: {ex.Message}");
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
    

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            

                // Obtener la fecha seleccionada del control MonthCalendar
                DateTime fechaSeleccionada = mcFecha.SelectionRange.Start;

                // Obtener la hora seleccionada del control ComboBox
                string horaSeleccionada = cboHora.SelectedItem.ToString();

                // Obtener el tipo de cita seleccionado del control ComboBox
                string tipoCitaSeleccionado = cboTipoDeCita.SelectedItem.ToString();

                // Obtener el especialista seleccionado del control ComboBox
                string especialistaSeleccionado = cboEspecialista.SelectedItem.ToString();

                int TuCedula = Convert.ToInt32(txtTuCedula.Text);
                // Preparar la consulta SQL para insertar los datos en la tabla
                string consultaSQL = "INSERT INTO tblReservarEspecialista (cmFecha, strHora, strTipoCita, strEspecialista, strTuCedula) " +
                                     "VALUES (@Fecha, @Hora, @TipoCita, @Especialista, @TuCedula)";

                // Crear una instancia de SqlCommand y asociarla a la conexión
                using (SqlCommand comando = new SqlCommand(consultaSQL, coneccion))
                {
                    // Asignar los valores a los parámetros de la consulta SQL
                    comando.Parameters.AddWithValue("@Fecha", fechaSeleccionada);
                    comando.Parameters.AddWithValue("@Hora", horaSeleccionada);
                    comando.Parameters.AddWithValue("@TipoCita", tipoCitaSeleccionado);
                    comando.Parameters.AddWithValue("@Especialista", especialistaSeleccionado);
                    comando.Parameters.AddWithValue("@TuCedula", TuCedula);

                    try
                    {
                        // Abrir la conexión a la base de datos
                        coneccion.Open();

                        // Ejecutar la consulta SQL
                        comando.ExecuteNonQuery();

                        // Mostrar mensaje de éxito
                        MessageBox.Show("Cita reservada con éxito. Volverás a la pantalla principal.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que pueda ocurrir durante la ejecución de la consulta
                        MessageBox.Show($"Error al reservar la cita: {ex.Message}");
                    }
                    finally
                    {
                        // Cerrar la conexión a la base de datos
                        coneccion.Close();
                    }
                }
            }

        
    }
}
