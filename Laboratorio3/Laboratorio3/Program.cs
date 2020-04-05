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
            List<Jefe> jefes = new List<Jefe>();
            List<Supervisor> supervisores = new List<Supervisor>();
            List<Cajero> cajeros = new List<Cajero>();
            List<Auxiliar> auxiliares = new List<Auxiliar>();

            void Separador()
            {
                Console.WriteLine(Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Environment.NewLine);
            } 
            
            int seleccion = 0;

            while (seleccion != 5)
            {
                Console.WriteLine(Environment.NewLine);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("SELECCIONE UNA OPCIÓN");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("[1]ENTAR COMO JEFE");
                Console.WriteLine("[2]ENTRAR COMO SUPERVISOR");
                Console.WriteLine("[3]ENTRAR COMO CAJERO");
                Console.WriteLine("[4]ENTAR COMO AUXILIAR");
                Console.WriteLine("[5]SALIR DEL PROGRAMA");
                Console.WriteLine(Environment.NewLine);
                seleccion = Convert.ToInt32(Console.ReadLine());

                if (seleccion == 1)
                {
                    Separador();
                    int opcion = 0;

                    while (opcion != 7)
                    {
                        Console.WriteLine("[1]AGREGAR JEFE");
                        Console.WriteLine("[2]MOSTRAR JEFES");
                        Console.WriteLine("[3]AGREGAR SUPERVISOR");
                        Console.WriteLine("[4]MOSTRAR SUPERVISORES");
                        Console.WriteLine("[5]CAMBIAR SUELDO SUPERVISOR");
                        Console.WriteLine("[6]CAMBIAR HORARIO SUPERVISOR");
                        Console.WriteLine("[7] <---- VOLVER ATRAS");
                        opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                jefes.Add(Jefe.AgregarJefe());
                                break;
                            case 2:
                                Jefe.MostrarJefes(jefes);
                                break;
                            case 3:
                                supervisores.Add(Supervisor.AgregarSupervisor());
                                break;
                            case 4:
                                Supervisor.MostrarSupervisores(supervisores);
                                break;
                            case 5:
                                supervisores = Supervisor.CambiarSueldo(supervisores);
                                break;
                            case 6:
                                supervisores = Supervisor.CambiarHorario(supervisores);
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (seleccion == 2)
                {
                    Separador();
                    int opcion2 = 0;

                    while (opcion2 != 13)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("SELECCIONE UNA OPCIÓN");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("[1]AGREGAR CLIENTE");
                        Console.WriteLine("[2]MOSTRAR CLIENTES");
                        Console.WriteLine("[3]AGREGAR PRODUCTO");
                        Console.WriteLine("[4]MOSTAR PRODCUTOS");
                        Console.WriteLine("[5]AGREGAR CAJERO");
                        Console.WriteLine("[6]MOSTAR CAJEROS");
                        Console.WriteLine("[7]CAMBIAR SUELDO CAJERO");
                        Console.WriteLine("[8]CAMBIAR HORARIO CAJERO");
                        Console.WriteLine("[9]AGREGAR AUXILIAR");
                        Console.WriteLine("[10]MOSTAR AUXILIARES");
                        Console.WriteLine("[11]CAMBIAR SUELDO AUXILIAR");
                        Console.WriteLine("[12]CAMBIAR HORARIO AUXILIAR");
                        Console.WriteLine("[13] <---- VOLVER ATRAS");
                        opcion2 = Convert.ToInt32(Console.ReadLine());

                        switch (opcion2)
                        {
                            case 1:
                                clientes.Add(Cliente.AgregarCliente());
                                break;
                            case 2:
                                Cliente.MostrarClientes(clientes);
                                break;
                            case 3:
                                productos.Add(Producto.AgregarProducto());
                                break;
                            case 4:
                                Producto.MostrarProductos(productos);
                                break;
                            case 5:
                                cajeros.Add(Cajero.AgregarCajero());
                                break;
                            case 6:
                                Cajero.MostrarCajeros(cajeros);
                                break;
                            case 7:
                                cajeros = Cajero.CambiarSueldo(cajeros);
                                break;
                            case 8:
                                cajeros = Cajero.CambiarHorario(cajeros);
                                break;
                            case 9:
                                auxiliares.Add(Auxiliar.AgregarAuxiliar());
                                break;
                            case 10:
                                Auxiliar.MostrarAuxiliares(auxiliares);
                                break;
                            case 11:
                                auxiliares = Auxiliar.CambiarSueldo(auxiliares);
                                break;
                            case 12:
                                auxiliares = Auxiliar.CambiarHorario(auxiliares);
                                break;
                            default:
                                break;
                        }
                    }
                } else if (seleccion == 3)
                {
                    Separador();
                    int opcion3 = 0;

                    while (opcion3 != 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("SELECCIONE UNA OPCIÓN");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("[1]REALIZAR VENTA");
                        Console.WriteLine("[2]MOSTRAR COMPRAS DE CADA CLIENTE");
                        Console.WriteLine("[3]MOSTRAR COMPRAS DE CADA CAJERO");
                        Console.WriteLine("[4] <---- VOLVER ATRAS");
                        opcion3 = Convert.ToInt32(Console.ReadLine());

                        switch (opcion3)
                        {
                            case 1:
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
                                            for (int i = 0; i < productos.Count; i++)
                                            {
                                                Console.WriteLine((i + 1) + "-" + productos[i].Informacion());
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
                            case 2:
                                foreach (Cliente cliente1 in clientes)
                                {
                                    cliente1.VerComprasCliente();
                                }
                                break;
                            case 3:
                                foreach (Cajero cajero1 in cajeros)
                                {
                                    cajero1.VerVentasCajero();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                } else if (seleccion == 4)
                {
                    Separador();
                } else if (seleccion == 5)
                {
                    Separador();
                    Console.WriteLine("Saliendo del programa...");
                    break;
                } else
                {
                    Console.WriteLine("Selecciones una opcion valida");
                }
            }
        }
    }
}