using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaVidaCadaDosTurnos
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0, dadoExtra = 0, total = 0, vidas = 3, contador = 0;
            while (true)
            {
                contador++;
                
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado);

                if (contador % 2 == 0) vidas--;//Lleva turnos pares, pierde una vida

                if (contador % 3 == 0) //Lleva turnos impares, saca dado extra
                {
                    dadoExtra = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado Extra: " + dadoExtra);

                    if (dado == dadoExtra) vidas++; //Dados dobles, vida extra
                }

                total += dado + dadoExtra;
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Vidas: " + vidas);

                if (vidas == 0) //Pierde
                {
                    Console.WriteLine("El juego ha finalizado");
                    break;
                }
                else
                {
                    Console.WriteLine("Desea lanzar de nuevo (s/n)");
                    if (Console.ReadLine() != "s") break; //No desea continuar
                }
            }
        }
    }
}
