
using System;

class Program
{
    static void Main()
    {
        // Programa que pide 5 números y determina si son positivos, negativos o cero
        // Además, indica si son pares o impares

        for (int i = 0; i < 5; i++) // estructura repetitiva
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());

            // Condicional anidada
            if (numero > 0)
            {
                Console.WriteLine("Es positivo");
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Además, es par");
                }
                else
                {
                    Console.WriteLine("Además, es impar");
                }
            }
            else if (numero < 0)
            {
                Console.WriteLine("Es negativo");
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Además, es par");
                }
                else
                {
                    Console.WriteLine("Además, es impar");
                }
            }
            else
            {
                Console.WriteLine("Es cero");
            }
        }
    }
}
