using System;

namespace P2E3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reciba 3 números y confirme si el tercero resulta de multiplicar los dos primeros.

            Console.Write("Primer Número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo Número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tercer Número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num3 == num1 * num2)
            {
                Console.WriteLine(num3 + " es producto de {0} * {1}", num1, num2);
            }
            else
            {
                Console.WriteLine(num3 + " no es producto de {0} * {1}", num1, num2);
            }

            Console.ReadKey();
        }
    }
}
