using System;

namespace leicht_kleinste_Zahl_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int zahl1, zahl2;
			
			
			Console.WriteLine("Zahlenvergleich\n");
			
			Console.Write("Eingabe der ersten Zahl:  ");
			zahl1 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Eingabe der zweiten Zahl:  ");
			zahl2 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("\n");
			
			if (zahl1 == zahl2)
			{
				Console.Write("Die eingegebenen Zahlen sind gleich.\n");
			}
			
			else if (zahl1 < zahl2)
			{
				Console.WriteLine("Die kleinste Zahl ist " + Convert.ToString (zahl1));
			}
			else if (zahl2 < zahl1)
			{
				Console.WriteLine("Die kleinste Zahl ist " + Convert.ToString (zahl2));
			}
			Console.Write("\n");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}

