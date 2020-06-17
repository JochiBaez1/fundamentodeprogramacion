using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace tarea_semana_6
{
    class Program
    {
        static void ejercicio_1() //Crear una aplicacion que muestre la tabla de multiplicar del (7)
        {
            int nUno = 7;
            int multiplicacion = 1;
            while (multiplicacion <= 10)
            {
                int nMultiplicar = nUno * multiplicacion;
                Console.WriteLine(nMultiplicar);
                multiplicacion++;
            }
            Console.WriteLine("");
        }
        static void ejercicio_2() //Crear una aplicacion que le pida al usuario un numero positivo y el sistema identifique si es primo o no.
        {
            Console.Write("Inserte el numero: ");
            int nUno = Convert.ToInt32(Console.ReadLine());

            if (nUno%2 == 1)
            {
                Console.WriteLine($"El numero {nUno} es un numero primo");
            }
            else 
            {
                Console.WriteLine($"El numero {nUno} no es un numero primo");
            }
            Console.WriteLine("");
        }
        static void ejercicio_3() //Crear un programa que me diga la cantidad de digitos que tiene un numero positivo
        {
            Console.Write("Inserte el numero: ");
            int nUno = Convert.ToInt32(Console.ReadLine());
            string digt = Convert.ToString(nUno);

            if (nUno > 0)
            {
                Console.WriteLine($"El numero insertado tiene {digt.Length} digitos");
            }
            else if (nUno < 0)
            {
                Console.WriteLine("El numero insertado es negativo");
            }
            Console.WriteLine("");
        }
        static void ejercicio_4() //Crear una aplicacion que genere un numero aleatorio entre 50 y 100.
        {
            static void random()
            {
                Random numeroRandom = new Random();
                int nUno = numeroRandom.Next(50, 100);
                Console.WriteLine(nUno);
            }
            random();
            while (true)
            {
                Console.Write("Quiere generar otro numero aleatorio? n-si o  s-para salir  : ");
                string decision = Convert.ToString(Console.ReadLine()).ToLower();
                

                switch (decision)
                {
                    case "n" :
                        random();
                        break;
                    case "s" :
                        Console.WriteLine("gracias por utilizar nuestro programa");
                        break;
                    default:
                        Console.WriteLine("la opcion no existe elija denuevo");
                        break;  
                }
                if (decision == "s")
                {
                    break;
                }
            }
            Console.WriteLine("");
        }
        static void ejercicio_5() //Crear una aplicacion que muestre la cantidad de 0 que hay del 1 al 100.
        {
            int count = 1;
            for (int i = 0; i < 100; i++)
            {
                string a = Convert.ToString(i);
                if (a.Contains("0"))
                {
                    
                    Console.WriteLine(count);
                    count= count + 1;
                }
                
            }
            Console.WriteLine(count);
            Console.WriteLine("");
        }
        static void ejercicio_6() //Recorrer los numeros del 1 al 50 en un ciclo for.
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
        }
        
        static void Main(string[] args)
        {
            while (true)
            {


                Console.Write("Inserte el ejercicio a ejecutar, del 1 al 6 o 7 para salir: ");
                int elegir = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (elegir)
                {
                    case 1:
                        ejercicio_1();
                        break;
                    case 2:
                        ejercicio_2();
                        break;
                    case 3:
                        ejercicio_3();
                        break;
                    case 4:
                        ejercicio_4();
                        break;
                    case 5:
                        ejercicio_5();
                        break;
                    case 6:
                        ejercicio_6();
                        break;
                    case 7:
                        Console.Write("gracias por correr los programas");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.Write("Debe elegir del 1 al 6");
                        break;
                }
                if (elegir == 7)
                {
                    break;
                }
            }
        }
    }
}
