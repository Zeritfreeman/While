using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosJugadores
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int jugador = 0, dado = 0, total = 0, contador = 0;
            Console.WriteLine("Ingrese la cantidad de jugadores entre 2 y 5");
            int n = int.Parse(Console.ReadLine());
            bool fueraDeLimite = n < 2 || n > 5;
            string respuesta = "s";
            bool respuestaInvalida = respuesta != "s" && respuesta != "n";

            while (fueraDeLimite) //No esta entre los limites
            {
                Console.WriteLine("No se puede ese numero de jugadores");
                n = int.Parse(Console.ReadLine());
                fueraDeLimite = n < 2 || n > 5;
            }

            while (jugador < n) //El numero de jugadores es correcto y desea continuar
            {
                Console.WriteLine("Hola jugador numero " + (jugador + 1));

                while (true)
                {
                    dado = aleatorio.Next(1, 3);
                    Console.WriteLine("Dado: " + dado);
                    total += dado;
                    Console.WriteLine("Total: " + total);

                    if (dado == 1) contador++; //Sacar uno
                    else contador = 0;

                    if (total >= 100) //Ganar el juego
                    {
                        Console.WriteLine("Ganaste");
                        break;
                    }
                    if (contador == 3) //Llevar tres unos
                    {
                        Console.WriteLine("Llevas 3 unos seguidos, perdiste");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Desea continuar (s/n)"); //No desea continuar
                        respuesta = Console.ReadLine();

                        while (respuestaInvalida) //Respuesta invalida
                        {
                            Console.WriteLine("Respuesta invalida, intentelo de nuevo");
                            respuesta = Console.ReadLine();
                            respuestaInvalida = respuesta != "s" || respuesta != "n";
                        }
                    }

                    if (respuesta == "n") break;
                }
                contador = 0;
                jugador++;
            }
        }
    }
}
