using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    class Cliente : Persona
    {
        public Cliente(string rut, string nombre, string apellido, string fechaNacimiento, string nacionalidad) : base(rut, nombre, apellido, fechaNacimiento, nacionalidad)
        {

        }

        List<string> compras = new List<string>(); //COMPRAS DE UN MISMO CLIENTE

        public void AñadirCompra(string compra)
        {
            compras.Add(compra);
        }

        public void VerComprasCliente()
        {
            Console.WriteLine(Environment.NewLine + "Compras de: " + Informacion() + Environment.NewLine);
            foreach(string compra in compras)
            {
                Console.WriteLine(compra);
            }
        }

        public static Cliente AgregarCliente()
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
            Cliente cliente = new Cliente(rut, nombre, apellido, fechaNacimiento, nacionalidad);
            return cliente;
        }

        public static void MostrarClientes(List<Cliente> clientes)
        {
            Console.WriteLine("Clientes:");
            foreach (Cliente elemento in clientes)
            {
                Console.WriteLine(elemento.Informacion());
            }
        }

    }
}
