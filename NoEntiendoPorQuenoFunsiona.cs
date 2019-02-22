using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Caras
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();

            int total = 0, dado = 0, valorEntero = (int)(dado / 2);
            double valorDecimal = (double)(dado / 2);
            string continuar = "s";

            bool condicionalA = total < 100 && continuar == "s";
            bool condicionalB = valorDecimal != valorEntero;

            while (condicionalA)
            {
                for (int i = 0; i <= 53; i++)
                {
                    dado = aleatorio.Next(1, 13);
                    Console.WriteLine("Dado: " + dado);
                    total += dado;
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("¿Desea lanzar de nuevo (s/n)?: ");
                    continuar = Console.ReadLine();
                    if (i < 4) continue;
                    if (condicionalB) break;
                }
            }
            Console.WriteLine("Termino el juego");
        }
    }
}
