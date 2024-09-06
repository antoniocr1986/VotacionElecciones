using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotoElectronico
{
    public partial class FormRegistro : Form
    {
        private readonly int mayoriaEdad = 18;

        FormVotacion ventanaVotacion = new FormVotacion();

        public static Dictionary<string, int> votosPorPartido = new Dictionary<string, int>();

        Conexion objetoConexion = new Conexion();

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            int edad;

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Introduce tu nombre");
            }
            if (string.IsNullOrWhiteSpace(textBoxApellidos.Text))
            {
                MessageBox.Show("Introduce tus apellidos");
            }
            if (checkBoxAntecedentes.Checked == true)
            {
                MessageBox.Show("Personas con antecedentes penales no pueden votar");
                return;
            }
            try
            {
                if (int.TryParse(textBoxEdad.Text, out edad))
                {
                    if (edad < mayoriaEdad)
                    {
                        MessageBox.Show("Menores de edad no pueden votar");
                        return;
                    }
                    if (!string.IsNullOrWhiteSpace(textBoxNombre.Text) && !string.IsNullOrWhiteSpace(textBoxApellidos.Text) 
                        && edad >= mayoriaEdad && !checkBoxAntecedentes.Checked)
                    {
                        MessageBox.Show("Dentro del if");
                        string nombre = textBoxNombre.Text ;
                        string apellidos = textBoxApellidos.Text;
                        // int age = Convert.ToInt32(textBoxEdad.Text);
                        bool antecedentes = checkBoxAntecedentes.Checked;

                        // Consulta SQL para insertar un votante
                        string query = "INSERT INTO Votante (Nombre, Apellidos, Edad, Antecedentes) " +
                                        "VALUES (@Nombre, @Apellidos, @Edad, @Antecedentes)";

                        // Usar SqlConnection para conectarse a la base de datos
                        using (SqlConnection conexion = objetoConexion.getConexion())
                        {
                            MessageBox.Show("Dentro del using");
                            try
                            {
                                // Crear el comando para la consulta de inserción
                                using (SqlCommand command = new SqlCommand(query, conexion))
                                {
                                    MessageBox.Show("Dentro del 2o using");
                                    // Parámetros para evitar inyección SQL
                                    command.Parameters.AddWithValue("@Nombre", nombre);
                                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                                    command.Parameters.AddWithValue("@Edad", edad);
                                    command.Parameters.AddWithValue("@Antecedentes", antecedentes);

                                    MessageBox.Show("confirmar4");
                                    // Ejecutar la consulta
                                    int rowsAffected = command.ExecuteNonQuery();

                                    MessageBox.Show("confirmar5");
                                    // Verificar si se ha insertado correctamente
                                    if (rowsAffected > 0)
                                    {
                                        Console.WriteLine("El votante ha sido insertado exitosamente.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se pudo insertar el votante.");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("DentroDelCatch");
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                    }
                    ventanaVotacion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Introduce un formato correcto en la edad");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Excepcion: " + ex.Message);
            }        
        }

        private void ButtonResultados_Click(object sender, EventArgs e)
        {
            bool VotacionComenzada = false;

            //***A1 Conectar con BD
            using (SqlConnection conexion = objetoConexion.getConexion())
            {
                string queryCount = "SELECT COUNT(*) FROM PartidoPolitico";
                string query = "SELECT Nombre, Votos FROM PartidoPolitico";

                SqlCommand comando = new SqlCommand(queryCount, conexion);

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Leer los datos fila por fila
                        while (reader.Read())
                        {
                            // Obtener el nombre y los votos de cada fila
                            string nombre = reader["Nombre"].ToString();
                            int votos = (int)reader["Votos"];

                            // Añadir los datos al diccionario
                            votosPorPartido[nombre] = votos;
                        }
                    }
                }

                int count = (int)comando.ExecuteScalar(); // Retorna el número de coincidencias

                if (count > 0)
                {
                    // Hay partidos politicos en la tabla
                    if (votosPorPartido != null && votosPorPartido.Count > 0)
                    {
                        string mensaje = "Resultados de la votación:\n\n";
                        foreach (var kvp in votosPorPartido)
                        {
                            mensaje += $"{kvp.Key}: {kvp.Value} votos\n";

                            VotacionComenzada = true;//LCH
                        }

                        if (VotacionComenzada)
                        {
                            MessageBox.Show(mensaje);
                        }
                        else
                        {
                            MessageBox.Show("Votación no comenzada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para ver de la votación");
                    }

                    if (conexion.State != ConnectionState.Open)
                    {
                        MessageBox.Show("No se pudo establecer conexión con la base de datos.");
                        return;
                    }
                }
            }
        }
    }
}
