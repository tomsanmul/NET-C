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
    public partial class FormListaMedicos : Form
    {
        private List<Persona> lmedicos = new List<Persona>();

        internal FormListaMedicos(List<Persona> listaPersonas)
        {
            foreach (Persona p in listaPersonas)
            {
                if (p.GetType().Name == "Medico")
                    lmedicos.Add(p);
            }
            InitializeComponent();
        }

        private void FormListaMedicos_Load(object sender, EventArgs e)
        {
            //lstMedicos.DataSource = lmedicos;   //Si uso el origen de datos DataSOurce, después no puedo borrar los elementos de la lista

            //El plan B es cargar la lista de uno en uno:

            // Agregar las columnas al control ListView:

            /*
            lstMedicos.Clear();
            lstMedicos.View = View.Details;
            lstMedicos.Nombre.Add("Apellidos", 50);
            lstMedicos.Apellidos.Add("Apellidos", 50);
            lstMedicos.Especialidad.Add("Especialidad", 100);
            lstMedicos.DNI.Add("DNI", 150);

            List<Employee> listaEmpleados = new List<Employee>();
            listaEmpleados = Dal.GetEmployees();

            foreach (Employee empleado in listaEmpleados)
            {

                ListViewItem item = new ListViewItem();

                item.Text = empleado.Employee_id.ToString();
                item.SubItems.Add(empleado.First_name.ToString());
                item.SubItems.Add(empleado.Last_name.ToString());
                item.SubItems.Add(empleado.Email.ToString());
                item.SubItems.Add(empleado.Phone_number.ToString());
                item.SubItems.Add(empleado.Hire_date.ToString());
                item.SubItems.Add(empleado.Job_id.ToString());
                item.SubItems.Add(empleado.Salary.ToString());
                item.SubItems.Add(empleado.Manager_id.ToString());
                item.SubItems.Add(empleado.Department_id.ToString());

                lstEmpleados.Items.Add(item);
            }
            */
        }

        private void btnElimnarMedico_Click(object sender, EventArgs e)
        {
            // Verificamos si hay algún ítem seleccionado
            if (lstMedicos.SelectedItems.Count > 0)
            {
                string medico = lstMedicos.SelectedItems[0].ToString();
                

                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el médico seleccionado?: \n" + medico, "Borrar Médico", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lstMedicos.Items.Remove(lstMedicos.SelectedItems[0]);
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado primero.");
            }
        }

        private void btcCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }   
}

