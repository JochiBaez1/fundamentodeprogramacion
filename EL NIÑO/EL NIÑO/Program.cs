using System;

namespace EL_NIÑO
{
    class Program
    {
        struct usuarios
        {
            public string nombre_;
            public long username_;
            public int clave_;
            public string rol_;
            public string fecha_creacion_;
            public string estado_;
        }
        static void menu()
        {
            usuarios[] nombre = new usuarios[3],
                username = new usuarios[3],
                clave = new usuarios[3],
                rol = new usuarios[3],
                fecha_creacion = new usuarios[3],
                estado = new usuarios[3];

            //ADMINISTRADOR
            nombre[0].nombre_ = "Josue Baez";
            nombre[0].username_ = 40201044146;
            nombre[0].clave_ = 1890;
            nombre[0].rol_ = "Administrador";
            nombre[0].fecha_creacion_ = "23/05/2017";
            nombre[0].estado_ = "activo";

            //SUPERVISOR
            nombre[1].nombre_ = "Manuel Perez";
            nombre[1].username_ = 40220137462;
            nombre[1].clave_ = 8522;
            nombre[1].rol_ = "Supervisor";
            nombre[1].fecha_creacion_ = "30/10/2016";
            nombre[1].estado_ = "activo";

            //VENDEDOR
            nombre[2].nombre_ = "Daniel Castro";
            nombre[2].username_ = 40215367924;
            nombre[2].clave_ = 9406;
            nombre[2].rol_ = "Vendedor";
            nombre[2].fecha_creacion_ = "20/02/2018";
            nombre[2].estado_ = "inactivo";

            Console.WriteLine("Bienvenido a la plataforma de la compañia");
            Console.WriteLine();

            Console.Write("Ingrese su username: ");
            try
            {
                long username_l = long.Parse(Console.ReadLine());
                string username_tamaño = Convert.ToString(username_l);
                Console.WriteLine();

                if (username_tamaño.Length == 11)
                {
                    if ((username_l == nombre[0].username_) || (username_l == nombre[1].username_) || (username_l == nombre[2].username_))
                    {
                        Console.Write("Inserte la clave del usuario: ");
                        try
                        {
                            long clave_l = long.Parse(Console.ReadLine());
                            string clave1_tamaño = Convert.ToString(clave_l);
                            Console.WriteLine();

                            if (clave1_tamaño.Length == 4)
                            {
                                if ((clave_l == nombre[0].clave_) || (clave_l == nombre[1].clave_) || (clave_l == nombre[2].clave_))
                                {
                                    if ((nombre[0].username_ == username_l && nombre[0].estado_ == "inactivo") || (nombre[1].username_ == username_l && nombre[1].estado_ == "inactivo") || (nombre[2].username_ == username_l && nombre[2].estado_ == "inactivo"))
                                    {
                                        Console.WriteLine("Su cuenta esta inactiva");
                                        Console.WriteLine();
                                        Console.WriteLine("Comuniquese con la compañia, para mas informacion");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Se ha logueado correctamente, Bienvenido.");
                                        if (username_l == nombre[0].username_)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Su usuario es {nombre[0].nombre_} y su rol {nombre[0].rol_} ");
                                        }
                                        else if (username_l == nombre[1].username_)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Su usuario es {nombre[1].nombre_} y su rol {nombre[1].rol_} ");
                                        }
                                        else if (username_l == nombre[2].username_)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"Su usuario es {nombre[2].nombre_} y su rol {nombre[2].rol_} ");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese una clave valida");
                                    Console.WriteLine();
                                    menu();
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ingrese una clave valida");
                                Console.WriteLine();
                                menu();
                            }
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ingrese una clave valida");
                            Console.WriteLine();
                            menu();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ingrese un username valido");
                        Console.WriteLine();
                        menu();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Ingrese un username valido");
                    Console.WriteLine();
                    menu();
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese un username valido");
                Console.WriteLine();
                menu();
            }
        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
