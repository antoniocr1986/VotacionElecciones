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
        FormVotacion ventanaVotacion = new FormVotacion();

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text) && int.Parse(textBoxEdad.Text) >= 18
                && !checkBoxAntecedentes.Checked)
                {             
                    ventanaVotacion.ShowDialog();
                }
                else
                {
                    if (string.IsNullOrEmpty(textBoxNombre.Text))
                    {
                        MessageBox.Show("Introduce tu nombre");
                    }
                    if (checkBoxAntecedentes.Checked)
                    {
                        MessageBox.Show("Personas con antecedentes penales no pueden votar");
                    }
                    if (Convert.ToInt32(textBoxEdad.Text) != 0 && Convert.ToInt32(textBoxEdad.Text) < 18 )
                    {
                        MessageBox.Show("Menores de edad no pueden votar");
                    }                 
                
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Excepcion: " + ex.Message);
            }
            
        }

        private void buttonResultados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Partido popular: " + ventanaVotacion.VotosPP + " votos\n" +
                "PSOE: " + ventanaVotacion.VotosPSOE + " votos\n" +
                "SUMAR: " + ventanaVotacion.VotosSUMAR + " votos\n" +
                "VOX: " + ventanaVotacion.VotosVOX + " votos\n" +
                "JUNTS: " + ventanaVotacion.VotosJUNTS + " votos\n" +
                "ERC: " + ventanaVotacion.VotosERC + " votos\n" +
                "PNV: " + ventanaVotacion.VotosPNV + " votos\n"+
                "EH Bildu: " + ventanaVotacion.VotosEHBildu + " votos");
        }
    }
}
