using System;
using System.Diagnostics;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //variable buleana para poder hacer el ciclo con las opciones 
            bool salir = false;

            do 
            {
                Console.WriteLine("\n*********************************");
                Console.WriteLine("Menu de opciones: ");
                Console.WriteLine("1. Opcion 1: Suma de Numeros pares e impares de un rango");
                Console.WriteLine("2. Opcion 2: Adivina el numero secreto (entre 1 y 10)");
                Console.WriteLine("3. Opcion 3: Tablas de multiplicar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("****************************************");

                Console.Write("Seleccione una opcion: ");
                string? opcion= Convert.ToString(Console.ReadLine());

                switch (opcion)
                {
                    
                    case "1":
                    
                        Console.WriteLine("\n**********Suma de Numeros Pares e Impares en un Rango**********");
                        Console.Write("Ingrese un numero entero positivo: ");

                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            int sumaPares = 0;
                            int sumaImpares = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    sumaPares += i; // SI ES PAR, SUMA AL ACUMULADOR DE PARES
                                }
                                else
                                {
                                    sumaImpares += i; //Si es impar,suma al acumulador de impares
                                }
                            }

                            Console.WriteLine("\nLa suma de los numeros pares en el rango es: "+ sumaPares);
                            Console.WriteLine("La suma de los numeros impares en el rango es: "+ sumaImpares);
                        }

                        else 
                        {
                            Console.WriteLine("Debe ingresar un numero entero positivo valido.");
                        }

                    case "2":
                        //se llama la funcion random para que se pueda usar en los numeros secretos aleatoriamente.
                        Random random = new();
                        //la varable numeroSecreto es igual a un rango del 1 al 11 porque en C# cuenta tambien el 0 
                        int numeroSecreto = random.Next(1,11);
                        int intentos = 0;
                        int intentoUsuario; 

                        Console.WriteLine("\n**************Adivina el numero secreto (entre 1 y 10)************");

                        while(true)
                        {
                            intentos++;

                            Console.Write("\nIngrese tu intento: ");
                            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                            {
                              if (intentoUsuario== numeroSecreto)
                              {
                                Console.WriteLine("¡Felicidades! Adivinaste el numero secreto el cual es: "+ numeroSecreto + "y fue adivinado en "+ intentos + "intentos.");
                              }  
                              else
                              {
                                Console.WriteLine("Intenta de nuevo.");
                              }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero valido.");
                            }
                        }  
                        break;

                    case "3":
                        Console.WriteLine("\n*******Tablas de multiplicar*******");
                        Console.Write("\nIngresa un numero para ver su tabla de multiplicar: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nTabla de multiplicar del " + numero + ":");

                        //utilizamos un bucle for para imprimir la tabla de multiplicar del numero ingresado
                        for (int i = 1; i <= 10; i++)
                        {
                            int resultado = numero * i;
                            Console.WriteLine(numero + "x" + i + "="+ resultado);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa..........");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine();
            } while (!salir);

             Console.ReadKey();
        }
    }
}
