using System;

namespace NumberPerfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int b; int num; int j;
            string divider = "";

            Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                b = 0;

                for (j = 1; j <= (i / 2); j++)
                {

                    if (i % j == 0)
                    {
                        b += j;
                        divider += " " + j + " ";

                    }

                }
                if (b == i) 
                Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + divider);
                divider = "";
            }
            Console.ReadKey();
        }
    }
}