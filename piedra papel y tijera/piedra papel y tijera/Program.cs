using System;

namespace piedra_papel_y_tijera
{
    class Program
    {

        static void jugadorvsbot() //funcion modo de jugador vs maquina
        {
            Console.WriteLine("Elija: 1-Piedra, 2-Papel o 3-Tijera");//aqui el jugador elije entre las 3 opciones
            try
            {
                int jugador1 = int.Parse(Console.ReadLine());

                Random eleccionR = new Random();//aqui se genera la opcion (en modo random) de la maquina
                int bot = eleccionR.Next(1, 3);
                string[] op = {"", "PIEDRA", "PAPEL", "TIJERA" };// array usado para printear la opcion de la maquina, ya que el random genera un numero
                if (jugador1 > 3)
                {
                    Console.WriteLine("elija una opcion valida");
                    jugadorvsbot();
                }
                else if ((jugador1 == 1 && bot == 3) || (jugador1 == 2 && bot == 1) || (jugador1 == 3 && bot == 2)) // esta es la decicion (con todas las posibles conbinaciones para que el jugador gane)
                {
                    Console.WriteLine($"ha ganado el jugador 1 con {op[jugador1]} vs {op[bot]}");/*aqui printea con que gano el jugador a la maquina,
                    y se utiliza el array para printear la opcion de la maquina y se utiliza el random para elegir la pocision del array a printear*/
                }
                else if ((bot == 1 && jugador1 == 3) || (bot == 2 && jugador1 == 1) || (bot == 3 && jugador1 == 2)) //aqui la decision donde gana la maquina
                {
                    Console.WriteLine($"ha ganado la maquina con {op[bot]} vs {op[jugador1]}");
                }
                else//aqui cuando ninguna de las condiciones de arriba se cumple es que hay un empate
                {
                    Console.WriteLine($"hay un empate");
                }
            }
            catch (System.Exception)// el try/catch se utiliza para solo admitir un tipo de dato en la opcion
            {
                Console.WriteLine("elija una opcion valida");
                jugadorvsbot();
            }
        }
        static void jugadorvsjugador() // aqui es la funcion para poner el modo de juego jugador contra jugador
        {

            Console.WriteLine("Jugador 1 Elija: 1-Piedra, 2-Papel o 3-Tijera");//aqui la opcion del jugador 1
            try
            {
                int jugador1 = int.Parse(Console.ReadLine());
                string[] opJugador = { "","PIEDRA", "PAPEL", "TIJERA" };// aqui otro array para printear con la opcion que elijan los jugadores
                if (jugador1 > 3 || jugador1 < 0)
                {
                    Console.WriteLine("elija una opcion valida");
                    jugadorvsjugador();
                }

                Console.WriteLine("Jugador 2 Elija: 1-Piedra, 2-Papel o 3-Tijera");//aqui la opcion del jugador 2
                try
                {
                    int jugador2 = int.Parse(Console.ReadLine());

                    if (jugador2 > 3 || jugador2 < 0)
                    {
                        Console.WriteLine("elija una opcion valida");
                        jugadorvsjugador();
                    }
                    else if ((jugador1 == 1 && jugador2 == 3) || (jugador1 == 2 && jugador2 == 1) || (jugador1 == 3 && jugador2 == 2))// esta es la decicion (con todas las posibles conbinaciones para que el jugador1 gane)
                    {
                        Console.WriteLine($"ha ganado el jugador 1 con {opJugador[jugador1]} vs {opJugador[jugador2]}");
                    }
                    else if ((jugador2 == 1 && jugador1 == 3) || (jugador2 == 2 && jugador1 == 1) || (jugador2 == 3 && jugador1 == 2))// esta es la decicion (con todas las posibles conbinaciones para que el jugador2 gane)
                    {
                        Console.WriteLine($"ha ganado el jugador 2 con {opJugador[jugador2]} vs {opJugador[jugador1]}");
                    }
                    else if ((jugador1 == 1 && jugador2 == 1) || (jugador1 == 2 && jugador2 == 2) || (jugador1 == 3 && jugador2 == 3))// esta es la decicion en caso de un empate
                    {
                        Console.WriteLine($"hay un empate");
                    }
                }
                catch (System.Exception)// el try/catch se utiliza para solo admitir un tipo de dato en la opcion
                {
                    Console.WriteLine("elija una opcion valida");
                    jugadorvsjugador();
                }
            }
            catch (System.Exception)// el try/catch se utiliza para solo admitir un tipo de dato en la opcion
            {
                Console.WriteLine("elija una opcion valida");
                jugadorvsjugador();
            }
        }
        static void juego()// esta funcion se utiliza para elegir el modo de juego
        {
            Console.WriteLine("1- para modo un jugador o 2- para modo 2 jugadores");
            Console.Write("Elija el modo a jugar: ");
            try
            {
                int modo = int.Parse(Console.ReadLine());
                switch (modo)// es switch se utiliza para correr el modo de juego, caso 1: un jugador vs la maquina, y el caso 2: modo 2 jugadores
                {
                    case 1:
                        jugadorvsbot();
                        break;
                    case 2:
                        jugadorvsjugador();
                        break;
                    default:
                        Console.WriteLine("elija un modo de juego valido: ");
                        break;
                }
            }
            catch (System.Exception)// el try/catch se utiliza para solo admitir un tipo de dato en la opcion
            {
                Console.WriteLine("elija un modo de juego valido");
                juego();
            }
        }
        static void Main(string[] args)
        {
            juego();
            while (true)// y este while se utiliza para mantener la aplicacion abierta hasta que el jugador o jugadores dejen de jugar
            {
                Console.WriteLine("Quiere jugar otra vez: 1-si o 2-no ");
                int denuevo = int.Parse(Console.ReadLine());

                switch (denuevo)
                {
                    case 1:
                        juego();
                        break;
                    case 2:
                        Console.WriteLine("Gracias por jugar");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                if (denuevo == 2)
                {
                    break;
                }
            }
        }
    }
}
