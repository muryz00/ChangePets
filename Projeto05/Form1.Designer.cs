namespace Projeto05
{
    partial class Form1
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
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.cboRaca = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.rdbMacho = new System.Windows.Forms.RadioButton();
            this.rdbFemea = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(235, 74);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(121, 21);
            this.cboEspecie.TabIndex = 0;
            // 
            // cboRaca
            // 
            this.cboRaca.FormattingEnabled = true;
            this.cboRaca.Location = new System.Drawing.Point(235, 157);
            this.cboRaca.Name = "cboRaca";
            this.cboRaca.Size = new System.Drawing.Size(121, 21);
            this.cboRaca.TabIndex = 1;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(173, 74);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Especie";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(173, 165);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 3;
            this.lblRaca.Text = "Raça";
            // 
            // rdbMacho
            // 
            this.rdbMacho.AutoSize = true;
            this.rdbMacho.Location = new System.Drawing.Point(198, 226);
            this.rdbMacho.Name = "rdbMacho";
            this.rdbMacho.Size = new System.Drawing.Size(58, 17);
            this.rdbMacho.TabIndex = 4;
            this.rdbMacho.TabStop = true;
            this.rdbMacho.Text = "Macho";
            this.rdbMacho.UseVisualStyleBackColor = true;
            // 
            // rdbFemea
            // 
            this.rdbFemea.AutoSize = true;
            this.rdbFemea.Location = new System.Drawing.Point(299, 226);
            this.rdbFemea.Name = "rdbFemea";
            this.rdbFemea.Size = new System.Drawing.Size(57, 17);
            this.rdbFemea.TabIndex = 5;
            this.rdbFemea.TabStop = true;
            this.rdbFemea.Text = "Femea";
            this.rdbFemea.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(238, 336);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Castração R$";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(235, 279);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rdbFemea);
            this.Controls.Add(this.rdbMacho);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.cboRaca);
            this.Controls.Add(this.cboEspecie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.ComboBox cboRaca;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.RadioButton rdbMacho;
        private System.Windows.Forms.RadioButton rdbFemea;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

