using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadoVidas
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, vidas = 3, contador1 = 0, contador2 = 0;
            

            while (true)
            {
                Console.WriteLine("Vidas: " + vidas);
                dado = aleatorio.Next(1, 3);
                Console.WriteLine("Dado: " + dado);
                total += dado;
                Console.WriteLine("Total: " + total);

                if (contador1 == 3 && dado == 1) //Pierde una vida
                {
                    vidas -= 1;
                    total -= 10;
                    contador1 = 0;
                }
                if (dado == 1) contador1 += 1;

                if (contador2 == 3 && dado == 6 && vidas < 3) //Gana una vida
                {
                    vidas += 1;
                    contador2 = 0;
                }
                if (dado == 6) contador2 += 1;
                else contador2 = 0;

                Console.WriteLine("Desea lanzar de nuevo (s/n)");
                if (Console.ReadLine() != "s" || vidas == 0) //No desea continuar O Pierde
                {
                    Console.WriteLine("El juego ha finalizado");
                    break;
                }
            }
        }
    }
}
