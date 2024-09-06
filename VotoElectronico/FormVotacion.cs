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

namespace VotoElectronico
{
    public partial class FormVotacion : Form
    {
        Conexion objetoConexion = new Conexion();

        public FormVotacion()
        {
            InitializeComponent();
        }

        private void ButtonConfirmarVoto_Click(object sender, EventArgs e)
        {
            if (!radioButtonPP.Checked && !radioButtonPSOE.Checked && !radioButtonSUMAR.Checked && !radioButtonVOX.Checked 
                && !radioButtonJUNTS.Checked && !radioButtonERC.Checked && !radioButtonEHBildu.Checked && !radioButtonPNV.Checked)
            {
                MessageBox.Show("Has de elejir un partido politico");
            }
            else
            {
                if (radioButtonPP.Checked)
                {
                    ActualizarVotos("PP");
                }
                else if (radioButtonPSOE.Checked)
                {
                    ActualizarVotos("PSOE");
                }
                else if (radioButtonSUMAR.Checked)
                {
                    ActualizarVotos("SUMAR");
                }
                else if (radioButtonVOX.Checked)
                {
                    ActualizarVotos("VOX");
                }
                else if (radioButtonERC.Checked)
                {
                    ActualizarVotos("JUNTS");
                }
                else if (radioButtonJUNTS.Checked)
                {
                    ActualizarVotos("ERC");
                }
                else if (radioButtonPNV.Checked)
                {
                    ActualizarVotos("PNV");
                }
                else if (radioButtonEHBildu.Checked)
                {
                    ActualizarVotos("EHBildu");
                }

                MessageBox.Show("Has introducido tu voto correctamente");
                this.Hide();
            }            
        }

        public void ActualizarVotos(string partidoPolitico)
        {
            string query = "UPDATE PartidoPolitico SET Votos = Votos + 1 WHERE Nombre = @Nombre";

            using (SqlConnection conexion = objetoConexion.getConexion())
            {
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@Nombre", partidoPolitico);  // Parámetro SQL

                try
                {
                    int filasAfectadas = command.ExecuteNonQuery();  // Ejecutar la consulta

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("El voto se ha registrado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("El partido político no fue encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
