using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsHospital
{
    internal class Medico : Persona
    {
        //Atributos privados
        private string especialidad;

        //Propiedades publicas
        public string Especialidad { get => especialidad; set => especialidad = value; }

        //Constructor/es
        public Medico()
        {
        }

        public Medico(string nombre, string apellidos, string dni, string especialidad) : base(nombre, apellidos, dni)
        {
            this.Especialidad = especialidad;
        }

        public override string ToString()
        {
            return base.ToString() + ". Especialidad: " + this.Especialidad;
        }

       



    }
}
