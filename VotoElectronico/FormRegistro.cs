using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public static Dictionary<string, int> votosPorPartido;

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxEdad.Text, out int edad))
                {
                    if (!string.IsNullOrWhiteSpace(textBoxNombre.Text) && !string.IsNullOrWhiteSpace(textBoxApellidos.Text) 
                        && int.Parse(textBoxEdad.Text) >= mayoriaEdad && !checkBoxAntecedentes.Checked)
                    {
                        ventanaVotacion.ShowDialog();
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                        {
                            MessageBox.Show("Introduce tu nombre");
                        }
                        if (string.IsNullOrWhiteSpace(textBoxApellidos.Text))
                        {
                            MessageBox.Show("Introduce tus apellidos");
                        }
                        if (checkBoxAntecedentes.Checked)
                        {
                            MessageBox.Show("Personas con antecedentes penales no pueden votar");
                        }
                        if (Convert.ToInt32(textBoxEdad.Text) != 0 && Convert.ToInt32(textBoxEdad.Text) < mayoriaEdad)
                        {
                            MessageBox.Show("Menores de edad no pueden votar");
                        }
                    }
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

            votosPorPartido = new Dictionary<string, int>
            {
                { "Partido Popular", ventanaVotacion.VotosPP },
                { "PSOE", ventanaVotacion.VotosPSOE },
                { "SUMAR", ventanaVotacion.VotosSUMAR },
                { "VOX", ventanaVotacion.VotosVOX },
                { "JUNTS", ventanaVotacion.VotosJUNTS },
                { "ERC", ventanaVotacion.VotosERC },
                { "PNV", ventanaVotacion.VotosPNV },
                { "EH Bildu", ventanaVotacion.VotosEHBildu }
            };

            if (votosPorPartido != null && votosPorPartido.Count > 0)
            {
                string mensaje = "Resultados de la votación:\n\n";
                foreach (var kvp in votosPorPartido)
                {
                    mensaje += $"{kvp.Key}: {kvp.Value} votos\n";
                    if (kvp.Value != 0)
                    {
                        VotacionComenzada = true;
                    }
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
        }
    }
}
