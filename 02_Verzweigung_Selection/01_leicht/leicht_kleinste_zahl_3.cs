using System;

namespace leicht_kleinste_Zahl_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int zahl1, zahl2, zahl3, kleinste_Zahl;
			
			kleinste_Zahl = 0; // Jede Variable braucht einen Wert, damit es funktioniert. Bei uns war es die 0.
				
			Console.WriteLine("Zahlenvergleich\n");
			
			Console.Write("Eingabe der ersten Zahl:  ");
			zahl1 = Convert.ToInt32(Console.ReadLine()); // Bei Int Variablen muss das "ToInt32" gemacht werden
			
			Console.Write("Eingabe der zweiten Zahl:  ");
			zahl2 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Eingabe der dritten Zahl:  ");
			zahl3 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("\n");
			
			if (zahl1 < zahl2)
			{
				kleinste_Zahl = zahl1;
			}
			else if (zahl2 < zahl1)
			{
				kleinste_Zahl = zahl2;
			}
			if (zahl3 < kleinste_Zahl)
			{
				kleinste_Zahl = zahl3;
			}
			Console.WriteLine("Die kleinste Zahl ist " + Convert.ToString (kleinste_Zahl));
			
			Console.Write("\n");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}