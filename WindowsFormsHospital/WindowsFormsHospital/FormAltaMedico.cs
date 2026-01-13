using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHospital
{
    public partial class FormAltaMedico : Form
    {
        internal Medico miMedico;
        public FormAltaMedico()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                miMedico = new Medico(txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtEspecialidad.Text);
                Close();
        }

        private void Campos_TextChanged(object sender, EventArgs e)
        {
            CompararCampo();
        }

        private void CompararCampo()
        {
            if ((!String.IsNullOrWhiteSpace(txtNombre.Text)) && 
                    (!String.IsNullOrWhiteSpace(txtApellidos.Text)) &&
                    (!String.IsNullOrWhiteSpace(txtDNI.Text)) &&
                    (!String.IsNullOrWhiteSpace(txtEspecialidad.Text)))
                btnGuardar.Enabled = true;
            else
                btnGuardar.Enabled = false;
        }
    }
}
