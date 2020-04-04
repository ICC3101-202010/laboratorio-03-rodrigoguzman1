using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    class Carrito
    {
        public Carrito()
        {

        }

        List<Producto> carrito = new List<Producto>();


        public void AgregarProducto(Producto producto, int cantidad)
        {
            if (producto.StockDisponible() && cantidad <= producto.stock)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    carrito.Add(producto);
                }

                producto.ActualizarStock(cantidad);

            } else if (producto.stock == 0){
                Console.WriteLine("Producto sin stock");

            } else
            {
                producto.ActualizarStock(cantidad);
            }
        }

        public int TotalCompra()
        {
            int total = 0;
            foreach (Producto producto in carrito)
            {
                total += producto.precio;
            }
            return total;
        }

        public void ProductosCarrito()
        {

            Console.WriteLine("Carrito:");
            foreach (Producto producto in carrito)
            {
                Console.WriteLine(producto.Informacion());
            }

            Console.WriteLine("Total: $" + TotalCompra());
        }


        public string FinalizarCompra(string rut, List<Cliente> clientes)
        {
            string compraFinal = "";
            Console.WriteLine(Environment.NewLine + "Fecha de compra (dd/mm/aaaa) :");
            string fechaCompra = Console.ReadLine();
            Console.WriteLine("Hora de compra (HH:MM) :");
            string horaCompra = Console.ReadLine();

            compraFinal = "Fecha de compra: " + fechaCompra + Environment.NewLine + "Hora de compra: " + horaCompra + Environment.NewLine + "Productos:"+ Environment.NewLine;
            foreach(Producto producto in carrito)
            {
                compraFinal += producto.Informacion() + Environment.NewLine;
            }
            compraFinal += "Total Compra $: " + TotalCompra() + Environment.NewLine;

            foreach(Cliente cliente in clientes)
            {
                if (cliente.rut == rut)
                {
                    compraFinal += "Cliente: " + cliente.Informacion();
                } 
            }
            return compraFinal;

        }
    }
}
