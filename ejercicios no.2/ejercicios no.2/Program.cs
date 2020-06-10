using System;

namespace ejercicios_no._2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*ejercicio 1: Crear un programa que use el operador condicional para mostrar el valor absoluto de un numero de la siguiente forma:
            si el numero es positivo, se mostrara tal cual; si es negativo, se mostrara el signo cambiado.*/

            //Console.Write("Inserte el numero: ");
            //string n1 = Console.ReadLine();
            //int nUno = int.Parse(n1);

            //if (nUno > 0)
            //{
            //    Console.WriteLine($"El valor absoluto del numero es {nUno}");
            //}
            //else if (nUno < 0)
            //{
            //    nUno = nUno * -1;
            //    Console.WriteLine($"El valor absoluto del numero es {nUno}");
            //}

            //ejercicio 2: Usar el operador condicional para calcular el menor de dos numeros.
            //Console.Write("Inserte el primer numero: ");
            //string n1 = Console.ReadLine();
            //int nUno = int.Parse(n1);

            //Console.Write("Inserte el segundo numero: ");
            //string n2 = Console.ReadLine();
            //int nDos = int.Parse(n2);

            //if (nUno < nDos)
            //{
            //    Console.WriteLine($"El numero {nUno} es menor al numero {nDos}");
            //}
            //else if (nDos < nUno)
            //{
            //    Console.WriteLine($"El numero {nDos} es menor al numero {nUno}");
            //}
            //else if (nUno == nDos)
            //{
            //    Console.WriteLine("Los numeros son iguales");
            //}

            /*ejercicio 3: Crear un programa que lea una letra tecleada por el usuario 
            y diga si se trata de un signo de puntuacion, una cifra numerica o algun otro caracter.*/

            Console.Write("inserte un caracter: ");
            string n = Console.ReadLine();

            if (n==";" || n==";" || n == "," || n == ".")
            {
                Console.WriteLine($"Usted inserto este signo de puntuacion ({n})");
            }
            else if (n == "0" || n == "1" || n == "2" || n == "3" || n == "4" || n == "5" || n == "6" || n == "7" || n == "8" || n == "9")
            {
                Console.WriteLine($"Usted inserto el numero ({n})");
            }
            else if (n.Length > 1)
            {
                Console.WriteLine("Usted inserto mas de un caracter");
            }
            else 
            {
                Console.WriteLine($"Usted inserto este caracter ({n})");
            }
            /*ejercicio 4: Crear un programa que lea una letra tecleada por el usuario 
            y diga si se trata de una vocal, una cifra numerica o una constante. Tips: usar dato tipo "char".*/


            //ejercicio 5: Crear un programa que escriba en pantalla los numeros pares del 23 al 7 en orden descendente, usando while.

            //int numeroUno = 23;
            //int numeroDos = 7;

            //while (true)
            //{
            //    numeroUno--;

            //    if (numeroUno % 2 == 0)
            //    {
            //        Console.WriteLine($"El numero {numeroUno} es par");
            //    }
            //    else if (numeroUno == numeroDos)
            //    {
            //        break;
            //    }

            //}



        }
    }
    
}
