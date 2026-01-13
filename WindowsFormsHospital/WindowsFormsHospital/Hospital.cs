using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHospital
{
    internal class Hospital

    {
        public List<Persona> lpersonas = new List<Persona>();

        public void AñadirPersona(Persona persona)
        {
            lpersonas.Add(persona);
        }
        public void ListarPersonas()
        {
            foreach (Persona p in lpersonas)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public bool HayMedicos()
        {
            if (lpersonas.Count > 0)
                return true;
            else
                return false;
        }
        public void ListarMedicos()
        {
            string medicos = "";
            foreach (Persona p in lpersonas)
            {
                if (p.GetType().Name == "Medico")
                    medicos += p.ToString() + "\n";
            }
            MessageBox.Show(medicos);
        }

        public List<Persona> ListarPersonasMedicos()
        {
            List<Persona> listaMedicos = new List<Persona>();
            foreach (Persona p in lpersonas)
            {
                if (p.GetType().Name == "Medico")
                {
                    listaMedicos.Add(p);
                }
            }
            return listaMedicos;
        }


        public void ListarPacientes()
        {
            foreach (Persona p in lpersonas)
            {
                if (p.GetType().Name == "Paciente")
                    Console.WriteLine(p.ToString());
            }
        }

        public void ListarPacientesDeUnMedico(Medico m)
        {
            foreach (Persona p in lpersonas)
            {
                if (p.GetType().Name == "Paciente")
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }

        public void EliminarPaciente(string dni)
        {
            bool encontrado = false;
            foreach (Persona p in lpersonas)
            {
                if ((p.GetType().Name == "Paciente") && (p.DNI == dni))
                {
                    encontrado = true;
                    Console.WriteLine("Paciente: " + p.ToString() + " ELIMINADO.");
                    lpersonas.Remove(p);
                    Console.WriteLine("\nPulsa una tecla para continuar....");
                    Console.ReadKey();
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("\nNO se ha encotrado ningún paciente con el DNI: " + dni);
                Console.WriteLine("\nPulsa una tecla para continuar....");
                Console.ReadKey();
            }
        }

        public Medico ElegirMedico()
        {
            int i = 1;
            int numOpcion;
            string opcion;
            Medico medico = new Medico();
            List<Persona> listaMedicos = new List<Persona>();

            Console.WriteLine("\nPrimero elige el medico para asignar al paciente:\n");
            foreach (Medico m in lpersonas)
            {
                if (m.GetType().Name == "Medico")
                {
                    Console.WriteLine(i + ": " + m.ToString());
                    listaMedicos.Add(m);
                }
                i++;
            }

            Console.WriteLine("\nElige medico:\n");
            do
            {
                opcion = Console.ReadLine();
                if ((!(int.TryParse(opcion, out numOpcion))) || (numOpcion > listaMedicos.Count) || (numOpcion <= 0))
                    Console.WriteLine("\nMedico NO válido, por favor elige primero el médico:\n");
            }
            while ((!(int.TryParse(opcion, out numOpcion))) || (numOpcion > listaMedicos.Count) || (numOpcion <= 0));

            return (Medico)listaMedicos[numOpcion - 1];
        }
        
    }
}