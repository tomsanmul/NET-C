using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsHospital
{
    internal class Persona
    {
        //Atributos privados
        private string nombre;
        private string apellidos;
        private string dNI;

        //Propiedades publicas
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string DNI { get => dNI; set => dNI = value; }

        public Persona()
        {

        }

        public Persona(string nombre, string apellidos, string dNI)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dNI;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellidos;
        }


    }
}
