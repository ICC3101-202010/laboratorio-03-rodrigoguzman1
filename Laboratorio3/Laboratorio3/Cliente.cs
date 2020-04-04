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

        
    }
}
