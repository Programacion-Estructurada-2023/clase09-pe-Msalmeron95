using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios con estructura selectiva IF - ELSE
            Console.WriteLine("\n\n---- PROMGRAMA QUE DETERMINA SI OBTUBO BUENA A EXCELENTE CALIFICACION ----");

            Console.WriteLine("\nIngrese su nota:");
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 9.5)
            {
                Console.WriteLine("La calificación obtenida es Excelente.");
            }
            else if (grade >= 8.5)
            {
                Console.WriteLine("La calificación obtenida es Muy Buena.");
            }
            else if (grade >= 7.0)
            {
                Console.WriteLine("La calificación obtenida es Buena.");
            }
            else
            {
                Console.WriteLine("La calificación obtenida es Deficiente.");
            }

            Console.ReadLine();
        }
    }
}