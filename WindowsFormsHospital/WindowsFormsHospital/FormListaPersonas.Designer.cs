namespace WindowsFormsHospital
{
    partial class FormListaPersonas
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
            this.btcCerrar = new System.Windows.Forms.Button();
            this.btnElimnarMedico = new System.Windows.Forms.Button();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btcCerrar
            // 
            this.btcCerrar.Location = new System.Drawing.Point(570, 385);
            this.btcCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btcCerrar.Name = "btcCerrar";
            this.btcCerrar.Size = new System.Drawing.Size(185, 53);
            this.btcCerrar.TabIndex = 6;
            this.btcCerrar.Text = "Cerrar";
            this.btcCerrar.UseVisualStyleBackColor = true;
            this.btcCerrar.Click += new System.EventHandler(this.btcCerrar_Click);
            // 
            // btnElimnarMedico
            // 
            this.btnElimnarMedico.Location = new System.Drawing.Point(46, 385);
            this.btnElimnarMedico.Margin = new System.Windows.Forms.Padding(4);
            this.btnElimnarMedico.Name = "btnElimnarMedico";
            this.btnElimnarMedico.Size = new System.Drawing.Size(185, 53);
            this.btnElimnarMedico.TabIndex = 5;
            this.btnElimnarMedico.Text = "Eliminar Persona";
            this.btnElimnarMedico.UseVisualStyleBackColor = true;
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.ItemHeight = 16;
            this.lstPersonas.Location = new System.Drawing.Point(46, 12);
            this.lstPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(708, 340);
            this.lstPersonas.TabIndex = 4;
            // 
            // FormListaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btcCerrar);
            this.Controls.Add(this.btnElimnarMedico);
            this.Controls.Add(this.lstPersonas);
            this.Name = "FormListaPersonas";
            this.Text = "FormListaPersonas";
            this.Load += new System.EventHandler(this.FormListaPersonas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btcCerrar;
        private System.Windows.Forms.Button btnElimnarMedico;
        private System.Windows.Forms.ListBox lstPersonas;
    }
}