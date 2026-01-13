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

    public partial class FormHospital : Form
    {

        internal Hospital h = new Hospital();

        public FormHospital()
        {
            InitializeComponent();
        }

        private void btnListaPacientes_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            if (h.HayMedicos())
            {
                FormListaPersonas fap = new FormListaPersonas(h.lpersonas);
                fap.ShowDialog(); 
            }
            else
                MessageBox.Show("No hay personas dadas de alta", "Error");
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            if (h.HayMedicos())
            {
                FormAltaPaciente fap = new FormAltaPaciente(h.lpersonas);
                fap.ShowDialog();
                h.AñadirPersona(fap.miPaciente);    
            }
            else
                MessageBox.Show("No hay médicos para asignar a un paciente.\nPrimero debes dar de alta un médico.","Error"); 
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            FormAltaMedico fam = new FormAltaMedico();
            fam.ShowDialog();
            //MessageBox.Show(fam.miMedico.ToString());
            h.AñadirPersona(fam.miMedico);
        }

        private void brnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListarMedicos_Click(object sender, EventArgs e)
        {
            if (h.HayMedicos())
            {
                FormListaMedicos flm = new FormListaMedicos(h.lpersonas);
                flm.ShowDialog();

            }
            else
                MessageBox.Show("No hay médicos listar.\nPrimero debes dar de alta un médico.", "Error");
        }
    }
}
