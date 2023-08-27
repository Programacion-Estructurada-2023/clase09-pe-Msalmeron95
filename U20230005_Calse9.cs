using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios con estructura selectiva IF - ELSE

            //Programa que determina si es mayor de edad.
            Console.WriteLine("\n\n---- PROMGRAMA QUE DETERMINA SI ES MAYOR ----");

            Console.WriteLine("\nIngrese tu edad: ");
            int edad = Convert.ToInt16(Console.ReadLine());

            if (edad >= 18 )
            {
                Console.WriteLine("Tu edad es " + edad + "ya eres mayor de edad ");

            }
            else
            {
                Console.WriteLine("Tu edad es " + edad + " eres menor de edad ");
            }


            Console.WriteLine("\n\n---- PROMGRAMA QUE DETERMINA SI ES MAYOR ----");
            Console.WriteLine("\nIngresa un numero: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("\nEl numero " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("\nEl numero " + numero + " es impar.");
            }

            Console.ReadLine();
        }
    }
}