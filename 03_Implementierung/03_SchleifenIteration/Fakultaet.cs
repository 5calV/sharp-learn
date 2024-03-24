using System;

namespace Fakultaet
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int zahl, ergebnis, zaehler;
			
			Console.WriteLine("Fakultät berechnen\n");
			
			Console.Write("Bitte geben Sie eine Zahl ein:  ");
			zahl = Convert.ToInt32(Console.ReadLine());
			
			ergebnis = zahl;
			
			for (zaehler = zahl; zaehler > 1; zaehler--) 
			{
				ergebnis = ergebnis * (zaehler - 1);
			}
			
			Console.WriteLine("\nDie Fakultät von {0} lautet {1}.", zahl, ergebnis);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}