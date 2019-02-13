using System;

class MainClass {
  public static void Main () {
    Random aleatorio = new Random();

		int carta1 = aleatorio.Next(1, 11);
		Console.WriteLine("Primera carta: " + carta1);
		int carta2 = aleatorio.Next(1, 11);
		Console.WriteLine("Segunda carta: " + carta2);
		int total = carta1 + carta2;
		Console.WriteLine("Su total es: " + total);
		Console.WriteLine("Desea continuar (s/n)");
		string continuar = Console.ReadLine();
		
		while (continuar == "s" && total < 21)
		{
			int carta3 = aleatorio.Next(1, 11);
			Console.WriteLine("Siguiente carta: " + carta3);
			total += carta3;
			Console.WriteLine("Su total es: " + total);
			if (total == 21) Console.WriteLine("Ganaste");
			else if (total > 21) Console.WriteLine("Perdiste");
			else 
			{
				Console.WriteLine("Desea continuar (s/n)");
				continuar = Console.ReadLine();
			}
    }
    if (continuar != "s") Console.WriteLine("Mera vuelta");
  }
}