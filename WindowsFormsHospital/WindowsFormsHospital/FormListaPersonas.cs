using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHospital
{
    public partial class FormListaPersonas : Form
    {

        private List<Persona> lpersonas = new List<Persona>();

        internal FormListaPersonas(List<Persona> listaPersonas)
        {
            lpersonas = listaPersonas;
            InitializeComponent();
        }

        private void FormListaPersonas_Load(object sender, EventArgs e)
        {
            lstPersonas.DataSource = lpersonas;
        }

        private void btcCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
