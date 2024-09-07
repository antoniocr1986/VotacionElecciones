namespace VotoElectronico
{
    partial class FormRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.checkBoxAntecedentes = new System.Windows.Forms.CheckBox();
            this.buttonResultados = new System.Windows.Forms.Button();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(27, 201);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(106, 35);
            this.buttonConfirmar.TabIndex = 6;
            this.buttonConfirmar.Text = "CONFIRMAR";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.ButtonConfirmar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(35, 43);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 18);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(131, 43);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(35, 115);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(42, 18);
            this.labelEdad.TabIndex = 3;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(131, 115);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 4;
            this.textBoxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdad_KeyPress);
            // 
            // checkBoxAntecedentes
            // 
            this.checkBoxAntecedentes.AutoSize = true;
            this.checkBoxAntecedentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAntecedentes.Location = new System.Drawing.Point(72, 156);
            this.checkBoxAntecedentes.Name = "checkBoxAntecedentes";
            this.checkBoxAntecedentes.Size = new System.Drawing.Size(171, 22);
            this.checkBoxAntecedentes.TabIndex = 5;
            this.checkBoxAntecedentes.Text = "Antecedentes penales";
            this.checkBoxAntecedentes.UseVisualStyleBackColor = true;
            // 
            // buttonResultados
            // 
            this.buttonResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultados.Location = new System.Drawing.Point(158, 195);
            this.buttonResultados.Name = "buttonResultados";
            this.buttonResultados.Size = new System.Drawing.Size(118, 46);
            this.buttonResultados.TabIndex = 7;
            this.buttonResultados.Text = "VER RESULTADOS";
            this.buttonResultados.UseVisualStyleBackColor = true;
            this.buttonResultados.Click += new System.EventHandler(this.ButtonResultados_Click);
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(35, 79);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(67, 18);
            this.labelApellidos.TabIndex = 9;
            this.labelApellidos.Text = "Apellidos";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(131, 79);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 3;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(303, 263);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.buttonResultados);
            this.Controls.Add(this.checkBoxAntecedentes);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormRegistro";
            this.Text = "REGISTRO VOTANTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.CheckBox checkBoxAntecedentes;
        private System.Windows.Forms.Button buttonResultados;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxApellidos;
    }
}

