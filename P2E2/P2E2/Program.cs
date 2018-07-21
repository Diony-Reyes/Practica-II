using System;

namespace P2E2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reciba 3 números por teclado y los imprima de menor a mayor

            Console.Write("Escriba el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriba el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriba el tercero numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("Primero: {0}", num1);
                Console.WriteLine("Segundo: {0}", num2);
                Console.WriteLine("Tercero: {0}", num3);
            }
            else if (num1 < num3 && num3 < num2)
            {
                Console.WriteLine("Primero: {0}", num1);
                Console.WriteLine("Segundo: {0}", num3);
                Console.WriteLine("Tercero: {0}", num2);
            }
            else if (num2 < num1 && num1 < num3)
            {
                Console.WriteLine("Primero: {0}", num2);
                Console.WriteLine("Segundo: {0}", num1);
                Console.WriteLine("Tercero: {0}", num3);
            }
            else if (num2 < num3 && num3 < num1)
            {
                Console.WriteLine("Primero: {0}", num2);
                Console.WriteLine("Segundo: {0}", num3);
                Console.WriteLine("Tercero: {0}", num1);
            }
            else if (num3 < num1 && num1 < num2)
            {
                Console.WriteLine("Primero: {0}", num3);
                Console.WriteLine("Segundo: {0}", num1);
                Console.WriteLine("Tercero: {0}", num2);
            }
            else
            {
                Console.WriteLine("Primero: {0}", num3);
                Console.WriteLine("Segundo: {0}", num2);
                Console.WriteLine("Tercero: {0}", num1);
            }

            Console.ReadKey();
        }
    }
}
