namespace VotoElectronico
{
    partial class FormVotacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConfirmarVoto = new System.Windows.Forms.Button();
            this.radioButtonPP = new System.Windows.Forms.RadioButton();
            this.radioButtonPSOE = new System.Windows.Forms.RadioButton();
            this.radioButtonVOX = new System.Windows.Forms.RadioButton();
            this.radioButtonSUMAR = new System.Windows.Forms.RadioButton();
            this.radioButtonERC = new System.Windows.Forms.RadioButton();
            this.radioButtonJUNTS = new System.Windows.Forms.RadioButton();
            this.radioButtonPNV = new System.Windows.Forms.RadioButton();
            this.radioButtonEHBildu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonConfirmarVoto
            // 
            this.buttonConfirmarVoto.Location = new System.Drawing.Point(136, 169);
            this.buttonConfirmarVoto.Name = "buttonConfirmarVoto";
            this.buttonConfirmarVoto.Size = new System.Drawing.Size(117, 23);
            this.buttonConfirmarVoto.TabIndex = 0;
            this.buttonConfirmarVoto.Text = "CONFIRMAR VOTO";
            this.buttonConfirmarVoto.UseVisualStyleBackColor = true;
            this.buttonConfirmarVoto.Click += new System.EventHandler(this.ButtonConfirmarVoto_Click);
            // 
            // radioButtonPP
            // 
            this.radioButtonPP.AutoSize = true;
            this.radioButtonPP.Location = new System.Drawing.Point(35, 28);
            this.radioButtonPP.Name = "radioButtonPP";
            this.radioButtonPP.Size = new System.Drawing.Size(97, 17);
            this.radioButtonPP.TabIndex = 1;
            this.radioButtonPP.TabStop = true;
            this.radioButtonPP.Text = "Partido Popular";
            this.radioButtonPP.UseVisualStyleBackColor = true;
            // 
            // radioButtonPSOE
            // 
            this.radioButtonPSOE.AutoSize = true;
            this.radioButtonPSOE.Location = new System.Drawing.Point(35, 61);
            this.radioButtonPSOE.Name = "radioButtonPSOE";
            this.radioButtonPSOE.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPSOE.TabIndex = 2;
            this.radioButtonPSOE.TabStop = true;
            this.radioButtonPSOE.Text = "PSOE";
            this.radioButtonPSOE.UseVisualStyleBackColor = true;
            // 
            // radioButtonVOX
            // 
            this.radioButtonVOX.AutoSize = true;
            this.radioButtonVOX.Location = new System.Drawing.Point(35, 99);
            this.radioButtonVOX.Name = "radioButtonVOX";
            this.radioButtonVOX.Size = new System.Drawing.Size(47, 17);
            this.radioButtonVOX.TabIndex = 3;
            this.radioButtonVOX.TabStop = true;
            this.radioButtonVOX.Text = "VOX";
            this.radioButtonVOX.UseVisualStyleBackColor = true;
            // 
            // radioButtonSUMAR
            // 
            this.radioButtonSUMAR.AutoSize = true;
            this.radioButtonSUMAR.Location = new System.Drawing.Point(35, 131);
            this.radioButtonSUMAR.Name = "radioButtonSUMAR";
            this.radioButtonSUMAR.Size = new System.Drawing.Size(64, 17);
            this.radioButtonSUMAR.TabIndex = 4;
            this.radioButtonSUMAR.TabStop = true;
            this.radioButtonSUMAR.Text = "SUMAR";
            this.radioButtonSUMAR.UseVisualStyleBackColor = true;
            // 
            // radioButtonERC
            // 
            this.radioButtonERC.AutoSize = true;
            this.radioButtonERC.Location = new System.Drawing.Point(225, 28);
            this.radioButtonERC.Name = "radioButtonERC";
            this.radioButtonERC.Size = new System.Drawing.Size(47, 17);
            this.radioButtonERC.TabIndex = 5;
            this.radioButtonERC.TabStop = true;
            this.radioButtonERC.Text = "ERC";
            this.radioButtonERC.UseVisualStyleBackColor = true;
            // 
            // radioButtonJUNTS
            // 
            this.radioButtonJUNTS.AutoSize = true;
            this.radioButtonJUNTS.Location = new System.Drawing.Point(225, 61);
            this.radioButtonJUNTS.Name = "radioButtonJUNTS";
            this.radioButtonJUNTS.Size = new System.Drawing.Size(60, 17);
            this.radioButtonJUNTS.TabIndex = 6;
            this.radioButtonJUNTS.TabStop = true;
            this.radioButtonJUNTS.Text = "JUNTS";
            this.radioButtonJUNTS.UseVisualStyleBackColor = true;
            // 
            // radioButtonPNV
            // 
            this.radioButtonPNV.AutoSize = true;
            this.radioButtonPNV.Location = new System.Drawing.Point(225, 99);
            this.radioButtonPNV.Name = "radioButtonPNV";
            this.radioButtonPNV.Size = new System.Drawing.Size(47, 17);
            this.radioButtonPNV.TabIndex = 7;
            this.radioButtonPNV.TabStop = true;
            this.radioButtonPNV.Text = "PNV";
            this.radioButtonPNV.UseVisualStyleBackColor = true;
            // 
            // radioButtonEHBildu
            // 
            this.radioButtonEHBildu.AutoSize = true;
            this.radioButtonEHBildu.Location = new System.Drawing.Point(225, 131);
            this.radioButtonEHBildu.Name = "radioButtonEHBildu";
            this.radioButtonEHBildu.Size = new System.Drawing.Size(66, 17);
            this.radioButtonEHBildu.TabIndex = 8;
            this.radioButtonEHBildu.TabStop = true;
            this.radioButtonEHBildu.Text = "EH Bildu";
            this.radioButtonEHBildu.UseVisualStyleBackColor = true;
            // 
            // FormVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(416, 204);
            this.Controls.Add(this.radioButtonEHBildu);
            this.Controls.Add(this.radioButtonPNV);
            this.Controls.Add(this.radioButtonJUNTS);
            this.Controls.Add(this.radioButtonERC);
            this.Controls.Add(this.radioButtonSUMAR);
            this.Controls.Add(this.radioButtonVOX);
            this.Controls.Add(this.radioButtonPSOE);
            this.Controls.Add(this.radioButtonPP);
            this.Controls.Add(this.buttonConfirmarVoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormVotacion";
            this.Text = "VOTACION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmarVoto;
        private System.Windows.Forms.RadioButton radioButtonPP;
        private System.Windows.Forms.RadioButton radioButtonPSOE;
        private System.Windows.Forms.RadioButton radioButtonVOX;
        private System.Windows.Forms.RadioButton radioButtonSUMAR;
        private System.Windows.Forms.RadioButton radioButtonERC;
        private System.Windows.Forms.RadioButton radioButtonJUNTS;
        private System.Windows.Forms.RadioButton radioButtonPNV;
        private System.Windows.Forms.RadioButton radioButtonEHBildu;
    }
}