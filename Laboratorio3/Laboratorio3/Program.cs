using System;
using System.Collections.Generic;

namespace Laboratorio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Producto> productos = new List<Producto>();

            int seleccion = 0;

            while (seleccion != 7)
            {
                Console.WriteLine(Environment.NewLine);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("SELECCIONE UNA OPCIÓN");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("[1]AGREGAR CLIENTE");
                Console.WriteLine("[2]MOSTRAR CLIENTES");
                Console.WriteLine("[3]AGREGAR PRODUCTO");
                Console.WriteLine("[4]MOSTAR PRODCUTOS");
                Console.WriteLine("[5]REALIZAR COMPRA");
                Console.WriteLine("[6]MOSTRAR COMPRAS DE CADA CLIENTE");
                Console.WriteLine("[7]SALIR DEL PROGRAMA");


                seleccion = Convert.ToInt32(Console.ReadLine());

                if (seleccion == 1 || seleccion == 2 || seleccion == 3 || seleccion == 4 || seleccion == 5 || seleccion == 6)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Environment.NewLine);
                    switch (seleccion)
                    {
                        case 1:
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

                            clientes.Add(cliente);
                            break;

                        case 2:
                            Console.WriteLine("Clientes:");
                            foreach(Cliente elemento in clientes)
                            {
                                Console.WriteLine(elemento.Informacion());
                            }
                            break;
                        case 3:
                            Console.WriteLine("Nombre:");
                            string nombreProducto = Console.ReadLine();
                            Console.WriteLine("Marca:");
                            string marcaProducto = Console.ReadLine();
                            Console.WriteLine("Precio: ");
                            int precio = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Stock: ");
                            int stock = Convert.ToInt32(Console.ReadLine());

                            Producto producto = new Producto(nombreProducto, precio, marcaProducto, stock);

                            productos.Add(producto);
                            break;
                        case 4:
                            Console.WriteLine("Productos:");
                            foreach (Producto elemento in productos)
                            {
                                Console.WriteLine(elemento.Informacion());
                            }
                            break;
                        case 5:
                            Carrito carrito = new Carrito();
                            Console.WriteLine("Rut Cliente:");
                            string rutCliente = Console.ReadLine();
                            

                            int eleccion = 0;

                            while (eleccion != 4)
                            {
                                Console.WriteLine("[1]AGREGAR PRODUCTO");
                                Console.WriteLine("[2]VER PRODUCTOS Y TOTAL CARRITO");
                                Console.WriteLine("[3]FINALIZAR COMPRA");
                                Console.WriteLine("[4]SALIR CARRITO SIN GUARDAR");

                                eleccion = Convert.ToInt32(Console.ReadLine());
                                
                                  
                                switch (eleccion)
                                {
                                    case 1:
                                        for(int i = 0; i < productos.Count; i++)
                                        {
                                            Console.WriteLine((i+1)+"-"+productos[i].Informacion());
                                        }
                                        Console.WriteLine("SELECCIONE UN PRODUCTO PARA AÑADIRLO");
                                        int productoElejido = Convert.ToInt32(Console.ReadLine()) - 1;
                                        Console.WriteLine("CANTIDAD: ");
                                        int cantidadProducto = Convert.ToInt32(Console.ReadLine());

                                        carrito.AgregarProducto(productos[productoElejido], cantidadProducto);

                                        break;
                                    case 2:
                                        carrito.ProductosCarrito();
                                        break;
                                    case 3:
                                        string compra = carrito.FinalizarCompra(rutCliente, clientes);
                                        foreach (Cliente usuario in clientes)
                                        {
                                            if (usuario.rut == rutCliente)
                                            {
                                                usuario.AñadirCompra(compra);
                                                Console.WriteLine("Añadido correctamente");
                                            }
                                        }

                                        break;
                                    case 4:
                                        Console.WriteLine("Saliendo sin guardar...");
                                        break;
                                    default:

                                        break;
                                }

                                if (eleccion == 3) { break; }
                            }

                            break;
                        case 6:
                            foreach(Cliente cliente1 in clientes)
                            {

                                cliente1.VerComprasCliente();
                            }
                            break;
                        case 7:
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Selecciones una opcion valida");
                            break;
                    }
                }




            }
        }
    }
}
