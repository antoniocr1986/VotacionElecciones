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
                    MessageBox.Show("Procedemos a la votacion y siguiente ventana por lo tanto");
                    FormVotacion ventanaVotacion = new FormVotacion();
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
    }
}
