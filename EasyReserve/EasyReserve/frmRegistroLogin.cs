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
    public partial class frmRegistroLogin : Form
    {
        public frmRegistroLogin()
        {
            InitializeComponent();
        }


        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection coneccion = new SqlConnection("server=SEBASZZ ; database = dboEasyReserve; INTEGRATED SECURITY = true");
        private void btnRegistro_Click(object sender, EventArgs e)
        {
           
                try
                {
                    coneccion.Open();

                    // Verificar si el usuario ya existe antes de realizar la inserción
                    SqlCommand verificarUsuario = new SqlCommand("SELECT COUNT(*) FROM tblLogin WHERE strUsuario = @strUsuario", coneccion);
                    verificarUsuario.Parameters.AddWithValue("@strUsuario", txtUsuario.Text);

                    int usuarioExistente = (int)verificarUsuario.ExecuteScalar();

                    if (usuarioExistente > 0)
                    {
                        MessageBox.Show("El usuario ya existe. Por favor, elija otro nombre de usuario.");
                    }
                    else
                    {
                        // El usuario no existe, proceder con la inserción
                        coneccion.Close();
                        coneccion.Open();

                        // Comando para insertar el nuevo usuario
                        SqlCommand comandoInsertar = new SqlCommand("INSERT INTO tblLogin (strUsuario, strContrasena) VALUES (@strUsuario, @strContrasena)", coneccion);
                        comandoInsertar.Parameters.AddWithValue("@strUsuario", txtUsuario.Text);
                        comandoInsertar.Parameters.AddWithValue("@strContrasena", txtContrasena.Text);

                        int filasAfectadas = comandoInsertar.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario registrado correctamente. Ahora puede iniciar sesión.");
                            this.Close();

                        frmLogin login = new frmLogin();
                        login.Show();
                        this.Close();
                        
                    }
                        else
                        {
                            MessageBox.Show("Error al registrar el usuario. Por favor, inténtelo de nuevo.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    coneccion.Close();
                }
       
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    }

