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
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxApellidos.Text))
            {
                MessageBox.Show("Introduce tus apellidos");
                return;
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
                        
                        string nombre = textBoxNombre.Text ;
                        string apellidos = textBoxApellidos.Text;
                        bool antecedentes = checkBoxAntecedentes.Checked;

                        if (VotanteExiste(nombre, apellidos, edad))
                        {
                            MessageBox.Show("El votante ya realizo su voto anteriormnete.");
                            return;
                        }
                        else
                        {
                            // Consulta SQL para insertar un votante
                            string query = "INSERT INTO Votante (Nombre, Apellidos, Edad, Antecedentes) " +
                                        "VALUES (@Nombre, @Apellidos, @Edad, @Antecedentes)";

                            // Usar SqlConnection para conectarse a la base de datos
                            using (SqlConnection conexion = objetoConexion.getConexion())
                            {
                                try
                                {
                                    // Crear el comando para la consulta de inserción
                                    using (SqlCommand command = new SqlCommand(query, conexion))
                                    {
                                        // Parámetros para evitar inyección SQL
                                        command.Parameters.AddWithValue("@Nombre", nombre);
                                        command.Parameters.AddWithValue("@Apellidos", apellidos);
                                        command.Parameters.AddWithValue("@Edad", edad);
                                        command.Parameters.AddWithValue("@Antecedentes", antecedentes);

                                        // Ejecutar la consulta
                                        int rowsAffected = command.ExecuteNonQuery();

                                        // Verificar si se ha insertado correctamente
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("El votante ha sido insertado exitosamente.");
                                            textBoxNombre.Text = "";
                                            textBoxApellidos.Text = "";
                                            textBoxEdad.Text = "";
                                            checkBoxAntecedentes.Checked = false;
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se pudo insertar el votante.");
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

        public bool VotanteExiste(string nombre, string apellidos, int edad)
        {
            // Consulta SQL para verificar si el votante existe
            string query = "SELECT COUNT(*) FROM Votante WHERE Nombre = @Nombre AND Apellidos = @Apellidos AND @Edad = @Edad";

            using (SqlConnection conexion = objetoConexion.getConexion())
            {
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@Nombre", nombre);  // Parámetros SQL
                command.Parameters.AddWithValue("@Apellidos", apellidos);
                command.Parameters.AddWithValue("@Edad", edad);

                try
                {
                    int count = (int)command.ExecuteScalar();  // Ejecutar consulta y obtener el número de coincidencias

                    return count > 0;  // Devuelve true si hay al menos una coincidencia, lo que indica que el votante existe
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
