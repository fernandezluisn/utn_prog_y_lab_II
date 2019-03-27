using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int Vmax = -100;
            int Vmin = 100;
            int acum = 0;
            float pr = 0;            

            Console.WriteLine("ingrese de a uno, 10 numeros entre -100 y 100");
            Console.WriteLine("ingrese número:");
            /*do
            {
                string j = Console.ReadLine();
                int.TryParse(j, out n1);
                P = Validacion.validar(n1, -100, 100);
            } while (P == true);*/

            for (int i=1; i<=10; i++)
            {
                string j = Console.ReadLine();
                int.TryParse(j, out n1);

                if (Validacion.validar(n1, -100, 100))
                {
                    if (Vmin > n1) Vmin = n1;
                    if (Vmax < n1) Vmax = n1;
                    acum = acum + n1;
                }
                else
                {
                    Console.WriteLine("ingrese nuevamente el número");
                    i--;
                }


            }
            pr = acum / 10;
            Console.WriteLine("el número menor es {0} \nel número mayor es {1} \nel promedio es {2}", Vmin, Vmax, pr);
            Console.Read();




        }
    }
}
