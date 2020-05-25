using Microsoft.VisualBasic;
using System;

namespace tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1

            Console.WriteLine("inserte el primer numero: ");
            string numeroUno = Console.ReadLine();
            int numUno = int.Parse(numeroUno);

            if (numUno % 2 == 0)
            {
                Console.WriteLine($"El numero {numUno} es un numero par");
            }
            else
            {
                Console.WriteLine($"El numero {numUno} es un numero inpar");
            }

            //ejercicio 2

            Console.WriteLine("inserte el primer numero: ");
            string nUno = Console.ReadLine();
            int n1 = int.Parse(nUno);

            Console.WriteLine("inserte el segundo numero: ");
            string nDos = Console.ReadLine();
            int n2 = int.Parse(nDos);

            if (n1 > n2)
            {
                Console.WriteLine($"El numero {n1} es mayor que {n2}");
            }
            else if (n1 == n2)
            {
                Console.WriteLine("Los numeros son iguales ");
            }
            else
            {
                Console.WriteLine($"El numero {n2} es mayor que {n1}");
            }

            //ejercicio 3

            Console.Write("inserte el primer numero: ");
            string nUno = Console.ReadLine();
            int n1 = int.Parse(nUno);

            Console.Write("inserte el segundo numero: ");
            string nDos = Console.ReadLine();
            int n2 = int.Parse(nDos);

            if (n1 % n2 == 0)
            {
                Console.WriteLine($"El numero {n1} es multiplo de {n2}");
            }
            else
            {
                Console.WriteLine($"El numero {n1} no es multiplo de {n2}");
            }

            //ejercicio 4

            Console.Write("inserte el numero: ");
            string nUno = Console.ReadLine();
            int n1 = int.Parse(nUno);

            int n2 = 10;

            if (n1 % n2 == 0)
            {
                Console.WriteLine($"El numero {n1} es multiplo de {n2} ");

                Console.Write("inserte un segundo numero multiplo de 10: ");
                string nTres = Console.ReadLine();
                int n3 = int.Parse(nTres);

                if (n3 % n2 == 0)
                {
                    Console.WriteLine($"El numero {n3} es multiplo de {n2} ");
                }
                else
                {
                    Console.WriteLine($"El numero {n3} no es multiplo de 10");
                }
            }
            else
            {
                Console.WriteLine($"El numero {n1} no es multiplo de 10");
            }

            //ejercicio 5

            Console.Write("inserte el primer numero: ");
            string numUno = Console.ReadLine();
            int num1 = int.Parse(numUno);

            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }

            else
            {
                Console.Write("inserte el segundo numero: ");
                string numDos = Console.ReadLine();
                int num2 = int.Parse(numDos);

                int producto = num1 * num2;

                Console.WriteLine($"El resultado del producto de los numeros {num1} y {num2} es {producto}");
            }

            //ejercicio 6

            Console.Write("inserte el primer numero: ");
            string nUno = Console.ReadLine();
            int n1 = int.Parse(nUno);

            if (n1 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            else
            {
                Console.Write("inserte el segundo numero: ");
                string nDos = Console.ReadLine();
                int n2 = int.Parse(nDos);

                int division = n1 / n2;

                Console.WriteLine($"El resultado de la division es: {division}");
            }

            //ejercicio 7

            Console.Write("inserte el primer numero: ");
            string nUno = Console.ReadLine();
            int n1 = int.Parse(nUno);

            int n2 = 4;
            int n3 = 5;

            if (n1 == 0)
            {
                Console.WriteLine("Todo numero multiplicado por 0 da 0");
            }
            else
            {
                if (n1 % n2 == 0)
                {
                    Console.WriteLine($"El numero {n1} es multiplo de {n2}");
                }
                else if (n1 % n3 == 0)
                {
                    Console.WriteLine($"El numero {n1} es multiplo de {n3}");
                }
                else
                {
                    Console.WriteLine($"El numero {n1} no es multiplo de {n2} y ni de {n3}");
                }
            }

            //ejercicio 8

            Console.Write("inserte el primer numero: ");
            string nUno = Console.ReadLine();
            int n1 = int.Parse(nUno);

            Console.Write("inserte el segundo numero: ");
            string nDos = Console.ReadLine();
            int n2 = int.Parse(nDos);

            if (n1 > 0 && n2 > 0)
            {
                Console.WriteLine("Los dos numeros son positivos");
            }
            else if (n1 < 0 && n2 < 0)
            {
                Console.WriteLine("Ninguno de los numeros son positivos");
            }
            else if (n1 > 0 || n2 > 0)
            {
                Console.WriteLine("Uno de los numeros es positivo");
            }

            //ejercicio 9

            Console.Write("inserte el primer numero: ");
            string nUno = Console.ReadLine();
            int n1 = int.Parse(nUno);

            Console.Write("inserte el segundo numero: ");
            string nDos = Console.ReadLine();
            int n2 = int.Parse(nDos);

            Console.Write("inserte el segundo numero: ");
            string nTres = Console.ReadLine();
            int n3 = int.Parse(nTres);

            if (n1>n2 && n1>n3)
            {
                Console.WriteLine("El primer numero es el mayor");
            }
            else if (n2>n1 && n2>n3)
            {
                Console.WriteLine("El segundo numero es el mayor");
            }
            else if (n3>n1 && n3>n2) 
            {
                Console.WriteLine("El tercer numero es el mayor");
            }
            else if (n1==n2 && n2==n3)
            {
                Console.WriteLine("Los numeros son iguales");
            }
        }
    }
}