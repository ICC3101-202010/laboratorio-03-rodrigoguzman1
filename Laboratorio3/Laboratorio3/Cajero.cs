using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    class Cajero : Empleado
    {
        public Cajero(string rut, string nombre, string apellido, string fechaNacimiento, string nacionalidad, int sueldo, string horaEntrada, string horaSalida) : base(rut, nombre, apellido, fechaNacimiento, nacionalidad, sueldo, horaEntrada, horaSalida)
        {

        }

        List<string> ventas = new List<string>();

        public void AñadirCompra(string compra)
        {
            ventas.Add(compra);
        }

        public void VerVentasCajero()
        {
            Console.WriteLine(Environment.NewLine + "Ventas de: " + Informacion() + Environment.NewLine);
            foreach (string venta in ventas)
            {
                Console.WriteLine(venta);
            }
        }

        public static Cajero AgregarCajero()
        {
            Console.WriteLine("Rut: ");
            string rutCajero = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            string nombreCajero = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellidoCajero = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento (dd/mm/aaaa): ");
            string fechaNacimientoCajero = Console.ReadLine();
            Console.WriteLine("Nacionalidad: ");
            string nacionalidadCajero = Console.ReadLine();
            Console.WriteLine("Sueldo:");
            int sueldoCajero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hora de entrada:");
            string horaEntradaCajero = Console.ReadLine();
            Console.WriteLine("Hora de salida:");
            string horaSalidaCajero = Console.ReadLine();
            Cajero cajero = new Cajero(rutCajero, nombreCajero, apellidoCajero, fechaNacimientoCajero, nacionalidadCajero, sueldoCajero, horaEntradaCajero, horaSalidaCajero);
            return cajero;
        }

        public static void MostrarCajeros(List<Cajero> cajeros)
        {
            Console.WriteLine("Cajeros:");
            foreach (Cajero elemento in cajeros)
            {
                Console.WriteLine(elemento.Informacion());
            }
        }

        public static List<Cajero> CambiarSueldo(List<Cajero> cajeros)
        {
            Console.WriteLine("RUT Cajero: ");
            string rutCajero1 = Console.ReadLine();
            Console.WriteLine("Nuevo Cajero:");
            int sueldoCajero1 = Convert.ToInt32(Console.ReadLine());
            foreach (Cajero usuario in cajeros)
            {
                if (usuario.rut == rutCajero1)
                {
                    usuario.SetSueldo(sueldoCajero1);
                }
            }

            return cajeros;
        }

        public static List<Cajero> CambiarHorario(List<Cajero> cajeros)
        {
            Console.WriteLine("RUT Cajero: ");
            string rutCajero2 = Console.ReadLine();
            Console.WriteLine("Hora Entrada:");
            string horaEntradaCajero1 = Console.ReadLine();
            Console.WriteLine("Hora Salida:");
            string horaSalidaCajero1 = Console.ReadLine();
            foreach (Cajero usuario in cajeros)
            {
                if (usuario.rut == rutCajero2)
                {
                    usuario.SetHorarioTrabajo(horaEntradaCajero1, horaSalidaCajero1);
                }
            }
            return cajeros;
        }

    }


}
