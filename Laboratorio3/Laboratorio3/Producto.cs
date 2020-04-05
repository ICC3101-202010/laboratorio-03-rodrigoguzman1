using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    class Producto
    {
        protected string nombre;
        public int precio;
        protected string marca;
        public int stock;

        public Producto(string nombre, int precio, string marca, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.stock = stock;
        }

        public void ActualizarStock(int cantidad)
        {
            if (this.stock - cantidad >= 0) {
                this.stock = stock - cantidad;
            } else
            {
                Console.WriteLine("No hay tanto stock disponible de ese producto, solo quedan: " + stock + " unidades");
            }
        }
        public bool StockDisponible()
        {
            if (stock > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string Informacion()
        {
            return "Nombre: "+ nombre + " Marca: " + marca + " Precio : $"+ precio + " Stock: "+ stock;
        }

        public string InformacionSinStock()
        {
            return "Nombre: " + nombre + " Marca: " + marca + " Precio : $" + precio;
        }

        public static Producto AgregarProducto()
        {
            Console.WriteLine("Nombre:");
            string nombreProducto = Console.ReadLine();
            Console.WriteLine("Marca:");
            string marcaProducto = Console.ReadLine();
            Console.WriteLine("Precio: ");
            int precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Producto producto = new Producto(nombreProducto, precio, marcaProducto, stock);

            return producto;
        }

        public static void MostrarProductos(List<Producto> productos)
        {
            Console.WriteLine("Productos:");
            foreach (Producto elemento in productos)
            {
                Console.WriteLine(elemento.Informacion());
            }
        }
    }
}
