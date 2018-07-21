using System;

namespace P2E4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Reciba el salario bruto de un empleado por teclado y aplique porcentaje
             de impuestos sobre la renta según corresponda, un cargo de 0.0287 de
             AFP y un cargo de 0.0304 de seguro familiar de salud, resultando el 
             sueldo neto. La salida debe decir:
             Sueldo Bruto: 25,000.00
             ISR: Exento
             SFS: 760.00
             AFP: 717.50
             Sueldo Neto: 23,522.50
             */

            double SueldoB, isr = 0, afp, sfs, SueldoN, anual;

            Console.Write("Introduzca el Salario Bruto: ");
            SueldoB = Convert.ToDouble(Console.ReadLine());

            anual = SueldoB * 12; //Sueldo Anual para calcula el ISR

            Console.Clear();

            Console.WriteLine("Sueldo Bruto: {0:N2}", SueldoB);
            
            //ISR
            if (anual <= 416220) //​Rentas hasta RD$416,220.00 - Exento
            {
                Console.WriteLine("ISR: Exento");
            }
            else if (anual >= 416220.01 && anual <= 624329.00) //Rentas desde RD$416,220.01 hasta RD$624,329.00 - 15% del excedente de RD$416,220.01
            {
                isr = ((anual - 416220.01) * 0.15) / 12; //Se divide entre 12 para determinar la mensualidad
                Console.WriteLine("ISR: {0:N2}", isr);
            }
            //​Rentas desde RD$624,329.01 hasta RD$867,123.00 - RD$31,216.00 más el 20% del excedente de RD$624,329.01
            else if (anual >= 624329.01 && anual <= 867123.00) 
            {
                double excedente = (anual - 624329.01) * 0.2;
                isr = (31216.00 + excedente) / 12;
                Console.WriteLine("ISR: {0:N2}", isr);
            }
            else if (anual > 867123.01) //Rentas desde  RD$867,123.01 en adelante - RD$79,776.00 más el 25% del excedente de RD$867,123.01
            {
                double excedente = (anual - 867123.01) * 0.25;
                isr = (79776.00 + excedente) / 12;
                Console.WriteLine("ISR: {0:N2}", isr);
            }

            //SFS
            Console.WriteLine("SFS: {0:N2}", sfs = SueldoB * 0.0304);

            //AFP
            Console.WriteLine("AFP: {0:N2}", afp = SueldoB * 0.0287);

            //Sueldo Neto
            Console.WriteLine("Sueldo Neto: {0:N2}", SueldoN = SueldoB - isr - sfs - afp);

            Console.ReadKey();
        }
    }
}
