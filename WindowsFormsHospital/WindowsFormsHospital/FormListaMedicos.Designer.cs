namespace WindowsFormsHospital
{
    partial class FormListaMedicos
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
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.btnElimnarMedico = new System.Windows.Forms.Button();
            this.btcCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 16;
            this.lstMedicos.Location = new System.Drawing.Point(51, 59);
            this.lstMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(708, 340);
            this.lstMedicos.TabIndex = 0;
            // 
            // btnElimnarMedico
            // 
            this.btnElimnarMedico.Location = new System.Drawing.Point(51, 432);
            this.btnElimnarMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElimnarMedico.Name = "btnElimnarMedico";
            this.btnElimnarMedico.Size = new System.Drawing.Size(185, 53);
            this.btnElimnarMedico.TabIndex = 2;
            this.btnElimnarMedico.Text = "Eliminar Médico";
            this.btnElimnarMedico.UseVisualStyleBackColor = true;
            this.btnElimnarMedico.Click += new System.EventHandler(this.btnElimnarMedico_Click);
            // 
            // btcCerrar
            // 
            this.btcCerrar.Location = new System.Drawing.Point(575, 432);
            this.btcCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcCerrar.Name = "btcCerrar";
            this.btcCerrar.Size = new System.Drawing.Size(185, 53);
            this.btcCerrar.TabIndex = 3;
            this.btcCerrar.Text = "Cerrar";
            this.btcCerrar.UseVisualStyleBackColor = true;
            this.btcCerrar.Click += new System.EventHandler(this.btcCerrar_Click_1);
            // 
            // FormListaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btcCerrar);
            this.Controls.Add(this.btnElimnarMedico);
            this.Controls.Add(this.lstMedicos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormListaMedicos";
            this.Text = "FormListaMedicos";
            this.Load += new System.EventHandler(this.FormListaMedicos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.Button btnElimnarMedico;
        private System.Windows.Forms.Button btcCerrar;
    }
}