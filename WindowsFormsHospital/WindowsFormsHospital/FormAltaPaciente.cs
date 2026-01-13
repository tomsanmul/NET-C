using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsHospital
{
    public partial class FormAltaPaciente : Form
    {
        internal Paciente miPaciente;

        private List<Persona> lmedicos = new List<Persona>();

        internal FormAltaPaciente(List<Persona> listaPersonas)
        {
            foreach (Persona p in listaPersonas)
            {
                if (p.GetType().Name == "Medico")
                    lmedicos.Add(p);
            }
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Paciente paciente = new Paciente();
            //MessageBox.Show(cmbMedico.);
            miPaciente = new Paciente(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtEnfermedad.Text, (Medico)cmbMedico.SelectedItem);
            Close();
        }
        private void CompararCampo()
        {
            if ((!String.IsNullOrWhiteSpace(txtNombre.Text)) &&
                    (!String.IsNullOrWhiteSpace(txtApellidos.Text)) &&
                    (!String.IsNullOrWhiteSpace(txtDNI.Text)) &&
                    (!String.IsNullOrWhiteSpace(txtEnfermedad.Text)) &&
                    (!String.IsNullOrWhiteSpace(cmbMedico.Text)))
                btnGuardar.Enabled = true;
            else
                btnGuardar.Enabled = false;
        }

        private void FormAltaPaciente_Load(object sender, EventArgs e)
        {
            foreach (Persona p in lmedicos)
            {
                    cmbMedico.Items.Add(p);
            }
        }
    }
}

