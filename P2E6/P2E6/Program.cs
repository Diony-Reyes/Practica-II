using System;

namespace P2E6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que reciba un numero y genere todas las tablas de multiplicar desde el 1 a ese número.

            Console.Write("Digite el número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int prod, c = 0;

            while(c <= numero)
            {
                c++;

                if (c <= numero)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("{0} * {1} = {2}", i, c, prod = i * c);
                    }

                    Console.WriteLine();
                }               

            }

            Console.ReadKey();
        }
    }
}
