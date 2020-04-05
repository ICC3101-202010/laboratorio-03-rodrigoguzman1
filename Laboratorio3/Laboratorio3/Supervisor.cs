using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    class Supervisor : Empleado
    {
        public Supervisor(string rut, string nombre, string apellido, string fechaNacimiento, string nacionalidad, int sueldo, string horaEntrada, string horaSalida) : base(rut, nombre, apellido, fechaNacimiento, nacionalidad, sueldo, horaEntrada, horaSalida)
        {

        }

        public static Supervisor AgregarSupervisor()
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
            Supervisor supervisor = new Supervisor(rut, nombre, apellido, fechaNacimiento, nacionalidad, sueldo, horaEntrada, horaSalida);
            return supervisor;
        }

        public static void MostrarSupervisores(List<Supervisor> supervisores)
        {
            Console.WriteLine("Supervisores:");
            foreach (Supervisor elemento in supervisores)
            {
                Console.WriteLine(elemento.Informacion());
            }
        }

        public static List<Supervisor> CambiarSueldo(List<Supervisor> supervisores)
        {
            Console.WriteLine("RUT Supervisor: ");
            string rutSupervisor1 = Console.ReadLine();
            Console.WriteLine("Nuevo Sueldo:");
            int sueldoSupervisor1 = Convert.ToInt32(Console.ReadLine());
            foreach (Supervisor usuario in supervisores)
            {
                if (usuario.rut == rutSupervisor1)
                {
                    usuario.SetSueldo(sueldoSupervisor1);
                }
            }

            return supervisores;
        }

        public static List<Supervisor> CambiarHorario(List<Supervisor> supervisores)
        {
            Console.WriteLine("RUT Supervisor: ");
            string rutSupervisor2 = Console.ReadLine();
            Console.WriteLine("Hora Entrada:");
            string horaEntradaSupervisor1 = Console.ReadLine();
            Console.WriteLine("Hora Salida:");
            string horaSalidaSupervisor1 = Console.ReadLine();
            foreach (Supervisor usuario in supervisores)
            {
                if (usuario.rut == rutSupervisor2)
                {
                    usuario.SetHorarioTrabajo(horaEntradaSupervisor1, horaSalidaSupervisor1);
                }
            }
            return supervisores;
        }

    }
}
