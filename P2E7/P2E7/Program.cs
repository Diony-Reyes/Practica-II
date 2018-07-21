using System;

namespace P2E7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Que funciones como un cajero automático que recibe una solicitud de
             retiro de un monto x, pero solo expide billetes de 1000, 500 y 100. Asi si 
             el usuario solicita retirar un monto que no puede ser dispensado, se le
             recordara los billetes que puede expedir. El cajero tendrá disponible
             200,000.00 Pesos. El monto solicitado deberá expedirse en billetes 
             según corresponda. Ejemplo: 2600

             2 billetes 1000
             1 billete de 500
             1 de 100
             */

            int billetes1000, billetes500, billetes100, resto;

            Console.Write("Monto a retirar: ");
            int monto = Convert.ToInt32(Console.ReadLine());

            billetes1000 = monto / 1000;
            resto = monto - billetes1000 * 1000;
            billetes500 = resto / 500;
            resto = resto - billetes500 * 500;
            billetes100 = resto / 100;
            resto = resto - billetes100 * 100;

            Console.Clear();

            if (monto <= 200000)
            {
                if (resto != 0)
                {
                    Console.WriteLine("Solo se puede expedir billetes de 1000, 500 y 100");
                }
                else
                {
                    Console.WriteLine("Monto: {0}", monto);
                    Console.WriteLine("{0} billetes de 1000", billetes1000);
                    Console.WriteLine("{0} billetes de 500", billetes500);
                    Console.WriteLine("{0} billetes de 100", billetes100);
                }
            }
            else Console.WriteLine("El monto máximo es de 200,000.00");
            

            Console.ReadKey();
        }
    }
}
