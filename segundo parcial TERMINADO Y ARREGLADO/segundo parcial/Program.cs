using System;

namespace segundo_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info_candidatos1 = {"PLD - PARTIDO DE LA LIBERACION DOMINICANA - 15 de diciembre de 1973.",    "Gonzalo Castillo.", "",
                                        "PRM - PARTIDO REVOLUCIONARIO MODERNO - 9 de septiembre de 2014.",          "Luis Abinader.",    "",
                                        "PRSC - PARTIDO REFORMISTA SOCIAL CRISTIANO - 21 de junio de 1963.",        "Leonel Fernandez.", "",
                                        "ALPAIS - ALANZA PAIS - 20 de febrero de 2011.",                            "Guillermo Moreno.", ""};

            string[] info_candidatos = {"PLD",   "Gonzalo Castillo", "Presidente",
                                        "PRM",   "Luis Abinader",    "Presidente",  
                                        "PRSC",  "Leonel Fernandez", "Presidente",
                                        "ALPAIS","Guillermo Moreno", "Presidente"};

            for (int i = 0; i < info_candidatos1.Length; i++)// bucle for para printear los datos de los candidatos
            {
                Console.WriteLine(info_candidatos1[i]);
            }

            int candidato1 = 0;//aqui se declaran las variable donde se almacenaran los votos
            int candidato2 = 0;
            int candidato3 = 0;
            int candidato4 = 0;

            int votos = 0;//conteo de los votos

            while (votos< 1000)// while con if, para asignar los votos
            {
                Random seleccion_cndto = new Random();// metodo random para elegir el candidato a votar
                int seleccion = seleccion_cndto.Next(1, 5);

                if (seleccion==1)// if para asignar los votos segun la opcion del random
                {
                    candidato1++;
                }
                else if (seleccion ==2)
                {
                    candidato2++;
                }
                else if (seleccion ==3)
                {
                    candidato3++;
                }
                else if (seleccion ==4)
                {
                    candidato4++;
                }

                votos = votos + 1;//mientras el while va iterando se le suma 1 a la variable votos y asi se le aplica un limite al bucle
            }
            if (candidato1==candidato2||candidato1==candidato3||candidato1==candidato4)//if para que no haya empate
            {
                candidato1++;
            }
            else if (candidato2==candidato3||candidato2==candidato4)
            {
                candidato2++;
            }
            else if (candidato3==candidato4)
            {
                candidato3++;
            }

            float porcentaje1 = ((candidato1 * 100) / 1000);//aqui se saca el porcentaje de los votos de todos los candidato
            float porcentaje2 = ((candidato2 * 100) / 1000);
            float porcentaje3 = ((candidato3 * 100) / 1000);
            float porcentaje4 = ((candidato4 * 100) / 1000);

            if (votos==1000)// si el conteo de los votos llega a 1000, se procede a buscar el ganador
            {
                    if (candidato1>candidato2 && candidato1>candidato3 && candidato1>candidato4)//condicion, por si gana el primer candidato
                    {
                        Console.WriteLine($"Ha ganado {info_candidatos[1]} del partido {info_candidatos[0]} con {candidato1} votos");
                        Console.WriteLine();
                        Console.WriteLine("El candidato posee el "+ porcentaje1 +"% de los votos");
                        Console.WriteLine();

                        if (candidato2 > candidato3 && candidato2 > candidato4)//aqui se procede a calcular las pocisiones de los otros candidatos
                        {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            Console.WriteLine();

                            if (candidato3>candidato4)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            }
                            
                        }
                        else if (candidato3> candidato2 && candidato3 > candidato4)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            Console.WriteLine();

                            if (candidato2>candidato4)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            }
                        }
                        else if (candidato4 > candidato2 && candidato4 > candidato3)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            Console.WriteLine();

                            if (candidato2>candidato3)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            }
                        }
                    }
                    else if (candidato2 > candidato1 && candidato2 > candidato3 && candidato2 > candidato4)//condicion, por si gana el segundo candidato candidato
                {
                        Console.WriteLine($"Ha ganado {info_candidatos[4]} del partido {info_candidatos[3]} con {candidato1} votos");
                        Console.WriteLine();
                        Console.WriteLine("El candidato posee el "+ porcentaje2 +"% de los votos");
                        Console.WriteLine();

                        if (candidato1 > candidato3 && candidato1 > candidato4)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            Console.WriteLine();

                            if (candidato3>candidato4)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            }
                            
                        }
                        else if (candidato3> candidato1 && candidato3 > candidato4)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            Console.WriteLine();

                            if (candidato1>candidato4)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            }
                        }
                        else if (candidato4 > candidato1 && candidato4 > candidato3)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            Console.WriteLine();

                            if (candidato1>candidato3)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            }
                        }
                    }
                    else if (candidato3 > candidato2 && candidato3 > candidato1 && candidato3 > candidato4)//condicion, por si gana el tercer candidato
                {
                        Console.WriteLine($"Ha ganado {info_candidatos[7]} del partido {info_candidatos[6]} con {candidato1} votos");
                        Console.WriteLine();
                        Console.WriteLine("El candidato posee el "+ porcentaje3 +"% de los votos");
                        Console.WriteLine();

                        if (candidato2 > candidato1 && candidato2 > candidato4)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            Console.WriteLine();

                            if (candidato1>candidato4)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            }
                            
                        }
                        else if (candidato1> candidato2 && candidato1 > candidato4)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            Console.WriteLine();

                            if (candidato2>candidato4)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            }
                        }
                        else if (candidato4 > candidato2 && candidato4 > candidato1)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[10]} con {candidato4} votos y {porcentaje4}%");
                            Console.WriteLine();

                            if (candidato2>candidato1)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            }
                        }
                    }
                    else if (candidato4 > candidato2 && candidato4 > candidato3 && candidato4 > candidato1)//condicion, por si gana el cuarto candidato
                {
                        Console.WriteLine($"Ha ganado {info_candidatos[10]} del partido {info_candidatos[9]} con {candidato1} votos");
                        Console.WriteLine();
                        Console.WriteLine("El candidato posee el "+ porcentaje4 +"% de los votos");
                        Console.WriteLine();

                        if (candidato2 > candidato3 && candidato2 > candidato1)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            Console.WriteLine();

                            if (candidato3>candidato1)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            }
                            
                        }
                        else if (candidato3> candidato2 && candidato3 > candidato1)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            Console.WriteLine();

                            if (candidato2>candidato1)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            }
                        }
                        else if (candidato1 > candidato2 && candidato1 > candidato3)//aqui se procede a calcular las pocisiones de los otros candidatos
                    {
                            Console.WriteLine($"El segundo candidato con mayor porcentaje es {info_candidatos[1]} con {candidato1} votos y {porcentaje1}%");
                            Console.WriteLine();

                            if (candidato2>candidato3)
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                            }
                            else
                            {
                                Console.WriteLine($"El tercer candidato con mayor porcentaje es {info_candidatos[7]} con {candidato3} votos y {porcentaje3}%");
                                Console.WriteLine();
                                Console.WriteLine($"El cuarto candidato con mayor porcentaje es {info_candidatos[4]} con {candidato2} votos y {porcentaje2}%");
                            }
                        }
                    }
            }
        }
    }
}
