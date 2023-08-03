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

        private void buttonConfirmarVoto_Click(object sender, EventArgs e)
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
                    VotosPP++;
                }
                if (radioButtonPSOE.Checked)
                {
                    VotosPSOE++;
                }
                if (radioButtonSUMAR.Checked)
                {
                    VotosSUMAR++;
                }
                if (radioButtonVOX.Checked)
                {
                    VotosVOX++;
                }
                if (radioButtonJUNTS.Checked)
                {
                    VotosJUNTS++;
                }
                if (radioButtonERC.Checked)
                {
                    VotosERC++;
                }
                if (radioButtonPNV.Checked)
                {
                    VotosPNV++;
                }
                if (radioButtonEHBildu.Checked)
                {
                    VotosEHBildu++;
                }
                MessageBox.Show("Has introducido tu voto correctamente");
                this.Hide();
            }    
        }

        private void FormVotacion_Load(object sender, EventArgs e)
        {

        }
    }
}
