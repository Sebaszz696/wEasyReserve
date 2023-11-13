using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyReserve
{
  

        internal class clsRegistro
        {
            SqlConnection coneccion = new SqlConnection("server=SEBASZZ ; database = dboEasyReserve; INTEGRATED SECURITY = true");

            public DateTime cmFecha { get; set; }
            public string strHora { get; set; }
            public string strTipoCita { get; set; }
            public string strEspecialista { get; set; }
            public int strTuCedula { get; set; }
            public int IDcita{ get; set; }
        //reserva espacio
            public int IDespacio { get; set; }
            public string strTipoEspacio { get; set; }
            public string strEscenario { get; set; }

        public clsRegistro() { }

        public clsRegistro(DateTime cmFecha, string strHora, string strTipoCita, string strEspecialista, int strTuCedula, int IDcita, int IDespacio, string strTipoEspacio, string strEscenario)
        {
            this.cmFecha = cmFecha;
            this.strHora = strHora;
            this.strTipoCita = strTipoCita;
            this.strEspecialista = strEspecialista;
            this.strTuCedula = strTuCedula;
            this.IDcita = IDcita;
            //reserva espacio
            this.IDespacio = IDespacio;
            this.strTipoEspacio = strTipoEspacio;
            this.strEscenario = strEscenario;
        }
    //---------------------------------------------Consultar y eliminar de citas, modificar y crear(reservar)  estan en frmReservarEspecialista--------------------------------------------------------------------//
        public DataTable consultarDatosPorCedula(int cedula)
        {
            coneccion.Open();

            DataTable tablaDatos = new DataTable();

            // Preparar la consulta SQL
            string consultaSQL = "SELECT * FROM tblReservarEspecialista WHERE strTuCedula = @TuCedula";

            // Crear una instancia de SqlCommand y asociarla a la conexión
            using (SqlCommand comando = new SqlCommand(consultaSQL, coneccion))
            {
                // Asignar el valor a los parámetros de la consulta SQL
                comando.Parameters.AddWithValue("@TuCedula", cedula);

                try
                {
                    // Ejecutar la consulta SQL y cargar los resultados en una DataTable
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tablaDatos);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Error al consultar datos por cédula: {ex.Message}");
                }
            }

            return tablaDatos;
        }
        public void eliminarDatosPorIDcita(int IDcita)
        {
            coneccion.Open();

            // Preparar la consulta SQL para eliminar la fila
            string consultaEliminarSQL = "DELETE FROM tblReservarEspecialista WHERE IDcita = @IDcita";

            // Crear una instancia de SqlCommand y asociarla a la conexión
            using (SqlCommand comandoEliminar = new SqlCommand(consultaEliminarSQL, coneccion))
            {
                // Asignar el valor a los parámetros de la consulta SQL
                comandoEliminar.Parameters.AddWithValue("@IDcita", IDcita);

                try
                {
                    // Ejecutar la consulta SQL para eliminar la fila
                    comandoEliminar.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar datos por IDcita: {ex.Message}");
                }
            }

            coneccion.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------//

        //---------------------------------------------Consultar y eliminar de espacios, modificar y crear(reservar)  estan en frmReservarEspacio--------------------------------------------------------------------//
        public DataTable consultarDatosPorCedulaEspacio(int cedula)
        {
            coneccion.Open();

            DataTable tablaDatos = new DataTable();

            // Preparar la consulta SQL
            string consultaSQL = "SELECT * FROM tblReservarEspacio WHERE strTuCedula = @TuCedula";

            // Crear una instancia de SqlCommand y asociarla a la conexión
            using (SqlCommand comando = new SqlCommand(consultaSQL, coneccion))
            {
                // Asignar el valor a los parámetros de la consulta SQL
                comando.Parameters.AddWithValue("@TuCedula", cedula);

                try
                {
                    // Ejecutar la consulta SQL y cargar los resultados en una DataTable
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tablaDatos);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error al consultar datos por cédula: {ex.Message}");
                }
            }

            return tablaDatos;
        }
        public void eliminarDatosPorIDEspacio(int IDespacio)
        {
            coneccion.Open();

            // Preparar la consulta SQL para eliminar la fila
            string consultaEliminarSQL = "DELETE FROM tblReservarEspacio WHERE IDespacio = @IDespacio";

            // Crear una instancia de SqlCommand y asociarla a la conexión
            using (SqlCommand comandoEliminar = new SqlCommand(consultaEliminarSQL, coneccion))
            {
                // Asignar el valor a los parámetros de la consulta SQL
                comandoEliminar.Parameters.AddWithValue("@IDespacio", IDespacio);

                try
                {
                    // Ejecutar la consulta SQL para eliminar la fila
                    comandoEliminar.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar datos por IDespacio: {ex.Message}");
                }
            }

            coneccion.Close();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------//


    }
}