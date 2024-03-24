using System;

namespace leicht_Prozentsatz
{
	class Program
	{
		public static void Main(string[] args)
		{
			double prozentsatz, zinsen, kapital;
			// Double: -1,79769313486232 * 10hoch38 + 1,79769313486232 * 10hoch38
			
			do // Beginn einer fußgesteuerten Schleife
			{
				Console.WriteLine("Bitte geben Sie das Kapital ein: ");
				kapital = Convert.ToDouble(Console.ReadLine());
				
				if (kapital == 0) // Nur wenn das Kapital gleich 0 ist, wird die folgende Zeile abgearbeitet.
				{
					Console.WriteLine("Das Kapital darf nicht 0 sein. Bitte geben Sie einen anderen Wert ein.");
				}
			}
			while (kapital == 0); // Ende der fußgesteuerten Schleife, in der abgefragt wird, ob das Kapital gleich 0 ist. Wenn ja wird wieder an den Anfang zu do gesprungen.
			
			Console.WriteLine("Bitte Ihre Zinsen eingeben:");
			zinsen = Convert.ToDouble(Console.ReadLine());
			
			prozentsatz = (zinsen * 100) / kapital;
			
			Console.Clear(); // Löscht die Konsole
			
			Console.WriteLine("Für das Kapital {0} Euro ergibt sich folgende Berechnung mit Zinsen von {1:0.00} Euro", kapital, zinsen);
			
			Console.WriteLine("Der berechnete Prozentsatz beträgt: {0:0.00} %", prozentsatz);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}