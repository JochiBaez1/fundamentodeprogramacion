using Microsoft.VisualBasic;
using System;

namespace tarea_Primer_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ejercicio 1
            Console.Write("inserte el dia: ");
            string dia = Console.ReadLine();

            if (dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine($"El dia {dia}, es fin de semana");
            }
            else
            {
                Console.WriteLine($"El dia {dia}, es dia de semana");

            }

            //ejercicio 2

            Console.Write("inserte el precio: ");//declaracion de la variable precio
            string precio1 = Console.ReadLine();
            int precioUno = int.Parse(precio1);

            if (precioUno > 0)// validar si el precio es positivo o negativo
            {
                Console.Write("elija su forma de pago, 1- tarjeta 2-efectivo: ");// elegir la forma de pago deseada
                string forma1 = Console.ReadLine();
                int formaUno = int.Parse(forma1);

                if (formaUno == 1)// forma de pago con tarjeta
                {
                    Console.Write($"Pague el monto de {precioUno} con la tarjeta"); // aqui muestra lo que pagara con la tarjeta

                    Console.Write("inserte los 12 digitos de su tarjeta: "); //aqui se insertan los digitos de la tarjeta
                    string tarjeta1 = Console.ReadLine();
                    long tarjetaUno = long.Parse(tarjeta1);

                    int tarjtDigito = tarjeta1.Length; //con el metodo length genero cuantos digitos inserto el usuario

                    if ( tarjtDigito == 12 ) // si el usuario inserto 12 digitos 
                    {
                        Console.WriteLine("Tarjeta aceptada, su pago ha sido efectuado");
                        Console.WriteLine("Gracias por su compra");
                    }
                    else if(tarjtDigito > 12) // si el usuario inserta mas de 2 digitos
                    {
                        Console.WriteLine("Los digitos insertados son mayor a 12");
                    }
                    else if (tarjtDigito < 12) // si el usuario inserta menos de 2 digitos
                    {
                        Console.WriteLine("Los digitos insertados son menor a 12");
                    }
                }
                else if (formaUno == 2) //forma de pago en efectivo
                {
                    Console.WriteLine($"Pague el monto de {precioUno} en efectivo"); // aqui muestra lo que pagara en efectivo

                    Console.Write("digite el monto en efectivo: "); //aqui se digita la cantidad de efectivo que da el usuario
                    string efectivo1 = Console.ReadLine(); 
                    int efectivoUno = int.Parse(efectivo1); 

                    if (efectivoUno != precioUno) //si la cantidad de efectivo es mayor al precio, aqui se calcula la devuelta
                    {
                        int devuelta = efectivoUno - precioUno; 
                        Console.WriteLine($"La devuelta es {devuelta}");
                        Console.WriteLine("Gracias por su compra");
                    }
                    else //si la cantidad de efectivo es igual al precio se printea esto
                    {
                        Console.WriteLine("Gracias por su compra");
                    }
                }
                else // si pone otra opcion que no sea las indicadas arriba da este error 
                {
                    Console.WriteLine("La opcion de pago no existe, ejecute denuevo");
                }
            }
            else// si el precio es negativo printea esto
            {
                Console.WriteLine("El numero es menor a 0");
            }       
        }
    }
}