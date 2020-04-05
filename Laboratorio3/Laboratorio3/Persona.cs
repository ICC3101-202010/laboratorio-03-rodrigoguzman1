using System;

namespace Laboratorio3
{
    partial class Persona
    {
        public string rut;
        protected string nombre;
        protected string apellido;
        protected string fechaNacimiento;
        protected string nacionalidad;

        public Persona()
        {

        }

        public Persona(string rut, string nombre, string apellido, string fechaNacimiento, string nacionalidad)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.nacionalidad = nacionalidad;
        }

        public string Informacion()
        {
            return "Rut: " + rut + ", Nombre: " + nombre + ", Apellido: " + apellido + ", Fecha Nacimiento: " + fechaNacimiento + ", Nacionalidad: " + nacionalidad;
        }
    }

}
