using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotoElectronico
{
    public partial class FormVotacion : Form
    {
        public int VotosPP {get; set;}
        public int VotosPSOE { get; set; }
        public int VotosSUMAR { get; set; }
        public int VotosVOX { get; set; }
        public int VotosJUNTS { get; set; }
        public int VotosERC { get; set; }
        public int VotosPNV { get; set; }
        public int VotosEHBildu { get; set; }

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
                if (sender is RadioButton radioButton)
                {
                    switch (radioButton.Name)
                    {
                        case "radioButtonPP":
                            VotosPP++;
                            break;

                        case "radioButtonPSOE":
                            VotosPSOE++;
                            break;

                        case "radioButtonSUMAR":
                            VotosSUMAR++;
                            break;

                        case "radioButtonVOX":
                            VotosVOX++;
                            break;

                        case "radioButtonERC":
                            VotosERC++;
                            break;

                        case "radioButtonJUNTS":
                            VotosJUNTS++;
                            break;

                        case "radioButtonPNV":
                            VotosPNV++;
                            break;

                        case "radioButtonEHBildu":
                            VotosEHBildu++;
                            break;

                        default:
                            break;
                    }
                }
                MessageBox.Show("Has introducido tu voto correctamente");
                this.Hide();
            }
        }
    }
}
