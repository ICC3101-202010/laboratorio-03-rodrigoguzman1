using System;

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

    }
}
