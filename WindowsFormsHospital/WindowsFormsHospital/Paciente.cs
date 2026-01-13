using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsHospital
{
    internal class Paciente : Persona
    {
        //Atributos privados
        private string enfermedad;
        private Medico medico;

        //Propiedades publicas
        public string Enfermedad { get => enfermedad; set => enfermedad = value; }
        public Medico Medico { get => medico; set => medico = value; }

        //Constructor/es

        public Paciente()
        {
        }

        public Paciente(string nombre, string apellidos, string dni, string enfermedad, Medico medico) : base(nombre, apellidos, dni)
        {
            this.Enfermedad = enfermedad;
            this.Medico = medico;
        }

        public Paciente(string nombre, string apellidos, string dni, string enfermedad) : base(nombre, apellidos, dni)
        {
            this.Enfermedad = enfermedad;
        }

        public override string ToString()
        {
            return this.Nombre + ' ' + this.Apellidos + ". Enfermedad: " + this.Enfermedad + ". Medico asignado: " + this.Medico.Nombre + " " + this.Medico.Apellidos;
        }


    }

}
