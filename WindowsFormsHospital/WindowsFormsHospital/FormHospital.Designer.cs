namespace WindowsFormsHospital
{
    partial class FormHospital
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
            this.btnAltaMedico = new System.Windows.Forms.Button();
            this.btnAltaPaciente = new System.Windows.Forms.Button();
            this.btnListarMedicos = new System.Windows.Forms.Button();
            this.btnListaPacientes = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnListarPersonas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaMedico
            // 
            this.btnAltaMedico.Location = new System.Drawing.Point(38, 76);
            this.btnAltaMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltaMedico.Name = "btnAltaMedico";
            this.btnAltaMedico.Size = new System.Drawing.Size(143, 37);
            this.btnAltaMedico.TabIndex = 0;
            this.btnAltaMedico.Text = "Alta de un Médico";
            this.btnAltaMedico.UseVisualStyleBackColor = true;
            this.btnAltaMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnAltaPaciente
            // 
            this.btnAltaPaciente.Location = new System.Drawing.Point(38, 145);
            this.btnAltaPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltaPaciente.Name = "btnAltaPaciente";
            this.btnAltaPaciente.Size = new System.Drawing.Size(143, 37);
            this.btnAltaPaciente.TabIndex = 2;
            this.btnAltaPaciente.Text = "Alta de un Paciente";
            this.btnAltaPaciente.UseVisualStyleBackColor = true;
            this.btnAltaPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnListarMedicos
            // 
            this.btnListarMedicos.Location = new System.Drawing.Point(242, 76);
            this.btnListarMedicos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarMedicos.Name = "btnListarMedicos";
            this.btnListarMedicos.Size = new System.Drawing.Size(143, 37);
            this.btnListarMedicos.TabIndex = 1;
            this.btnListarMedicos.Text = "Listar los Médicos";
            this.btnListarMedicos.UseVisualStyleBackColor = true;
            this.btnListarMedicos.Click += new System.EventHandler(this.btnListarMedicos_Click);
            // 
            // btnListaPacientes
            // 
            this.btnListaPacientes.Location = new System.Drawing.Point(242, 214);
            this.btnListaPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListaPacientes.Name = "btnListaPacientes";
            this.btnListaPacientes.Size = new System.Drawing.Size(143, 37);
            this.btnListaPacientes.TabIndex = 5;
            this.btnListaPacientes.Text = "Pacientes de un Médico";
            this.btnListaPacientes.UseVisualStyleBackColor = true;
            this.btnListaPacientes.Click += new System.EventHandler(this.btnListaPacientes_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Location = new System.Drawing.Point(242, 145);
            this.btnEliminarPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(143, 37);
            this.btnEliminarPaciente.TabIndex = 3;
            this.btnEliminarPaciente.Text = "Eliminar un Paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnListarPersonas
            // 
            this.btnListarPersonas.Location = new System.Drawing.Point(38, 214);
            this.btnListarPersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarPersonas.Name = "btnListarPersonas";
            this.btnListarPersonas.Size = new System.Drawing.Size(143, 37);
            this.btnListarPersonas.TabIndex = 4;
            this.btnListarPersonas.Text = "Listado de Personas";
            this.btnListarPersonas.UseVisualStyleBackColor = true;
            this.btnListarPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(148, 301);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(143, 37);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.brnCerrar_Click);
            // 
            // FormHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 366);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnListarPersonas);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.btnListaPacientes);
            this.Controls.Add(this.btnListarMedicos);
            this.Controls.Add(this.btnAltaPaciente);
            this.Controls.Add(this.btnAltaMedico);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHospital";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaMedico;
        private System.Windows.Forms.Button btnAltaPaciente;
        private System.Windows.Forms.Button btnListarMedicos;
        private System.Windows.Forms.Button btnListaPacientes;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnListarPersonas;
        private System.Windows.Forms.Button btnCerrar;
    }
}