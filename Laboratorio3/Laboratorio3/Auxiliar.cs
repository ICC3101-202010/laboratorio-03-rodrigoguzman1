using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    class Auxiliar : Empleado
    {
        public Auxiliar(string rut, string nombre, string apellido, string fechaNacimiento, string nacionalidad, int sueldo, string horaEntrada, string horaSalida) : base(rut, nombre, apellido, fechaNacimiento, nacionalidad, sueldo, horaEntrada, horaSalida)
        {

        }

        public static Auxiliar AgregarAuxiliar()
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
            Auxiliar auxiliar = new Auxiliar(rut, nombre, apellido, fechaNacimiento, nacionalidad, sueldo, horaEntrada, horaSalida);
            return auxiliar;
        }

        public static void MostrarAuxiliares(List<Auxiliar> auxiliares)
        {
            Console.WriteLine("Auxiliares:");
            foreach (Auxiliar elemento in auxiliares)
            {
                Console.WriteLine(elemento.Informacion());
            }
        }

        public static List<Auxiliar> CambiarSueldo(List<Auxiliar> auxiliares)
        {
            Console.WriteLine("RUT Auxiliar: ");
            string rutAuxiliar1 = Console.ReadLine();
            Console.WriteLine("Nuevo Sueldo:");
            int sueldoAuxiliar1 = Convert.ToInt32(Console.ReadLine());
            foreach (Auxiliar usuario in auxiliares)
            {
                if (usuario.rut == rutAuxiliar1)
                {
                    usuario.SetSueldo(sueldoAuxiliar1);
                    Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("SUELDO CAMBIADO CON EXITO");
                    Console.WriteLine(Environment.NewLine); Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            return auxiliares;
        }

        public static List<Auxiliar> CambiarHorario(List<Auxiliar> auxiliares)
        {
            Console.WriteLine("RUT Auxiliar: ");
            string rutAuxiliar2 = Console.ReadLine();
            Console.WriteLine("Hora Entrada:");
            string horaEntradaAuxiliar1 = Console.ReadLine();
            Console.WriteLine("Hora Salida:");
            string horaSalidaAuxiliar1 = Console.ReadLine();
            foreach (Auxiliar usuario in auxiliares)
            {
                if (usuario.rut == rutAuxiliar2)
                {
                    usuario.SetHorarioTrabajo(horaEntradaAuxiliar1, horaSalidaAuxiliar1);
                    Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("HORARIO CAMBIADO CON EXITO");
                    Console.WriteLine(Environment.NewLine); Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            return auxiliares;
        }

        public static void LimpiarPasillo(List<Auxiliar> auxiliares)
        {
            Console.WriteLine("RUT AUXILIAR: ");
            string rut = Console.ReadLine();
            Console.WriteLine("INGRESE NUMERO DE PASILLO QUE DESEA LIMPIAR: ");
            string numeroPasillo = Console.ReadLine();
            foreach(Auxiliar usuario in auxiliares)
            {
                if (usuario.rut == rut)
                {
                    string nombreAuxiliar = usuario.nombre;
                    string apellidoAuxiliar = usuario.apellido;

                    Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine(Environment.NewLine);
                    Console.WriteLine(nombreAuxiliar + " " + apellidoAuxiliar + " ha limpiado el pasillo " + numeroPasillo);
                    Console.BackgroundColor = ConsoleColor.Black;
                } else
                {
                    Console.WriteLine("No hay auxiliar registado con ese Rut");
                }
            }

        }

    }
}

