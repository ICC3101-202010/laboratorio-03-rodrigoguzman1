using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    class Jefe : Empleado
    {

        public Jefe(string rut, string nombre, string apellido, string fechaNacimiento, string nacionalidad, int sueldo, string horaEntrada, string horaSalida) : base(rut, nombre, apellido, fechaNacimiento, nacionalidad, sueldo, horaEntrada ,horaSalida)
        {

        }

        public static Jefe AgregarJefe()
        {
            Console.WriteLine("Rut: ");
            string rut = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento (dd/mm/aaaa): ");
            string fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Nacionalidad: ");
            string nacionalidad = Console.ReadLine();
            Console.WriteLine("Sueldo:");
            int sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hora de entrada:");
            string horaEntrada = Console.ReadLine();
            Console.WriteLine("Hora de salida:");
            string horaSalida = Console.ReadLine();
            Jefe jefe = new Jefe(rut, nombre, apellido, fechaNacimiento, nacionalidad, sueldo, horaEntrada, horaSalida);
            return jefe;
        }

        public static void MostrarJefes(List<Jefe> jefes)
        {
            Console.WriteLine("Jefes:");
            foreach (Jefe elemento in jefes)
            {
                Console.WriteLine(elemento.Informacion());
            }
        }
    }

}
