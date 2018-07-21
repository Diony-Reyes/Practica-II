using System;

namespace P2E5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Reciba un usuario y una contraseña. Si el usuario ingresa sus datos mal 3 
             veces debe notificársele que ha intentado iniciar sesión 3 veces. 
             Que contacte al administrador
             */


            int c = 0;
            string usuario, password;

            do
            {

                Console.Write("Usuario: ");
                usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                password = Console.ReadLine();

                if (usuario!="admin" || password != "123456")
                {
                    c++;
                    Console.Clear();

                    if (c == 3)
                    {
                        Console.WriteLine("HA INTENTADO INICIAR SESIÓN 3 VECES. CONTACTE AL ADMINISTRADOR");
                    }
                                
                }
                else Console.WriteLine("BIENVENIDO!!");

            } while ((usuario!="admin" || password!="123456") && c < 3);

            
            Console.ReadKey();

        }
    }
}
