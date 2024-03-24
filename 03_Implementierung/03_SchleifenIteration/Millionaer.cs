using System;

namespace Millionaer
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double einlage_in_euro = 0, zinsen, wert_am_jahresanfang;
			int zinssatz, anfangsjahr;
			
			Console.WriteLine("Wie lange dauert es, um Millionär zu werden?");
			
			Console.Write("\nEinlage in Euro   :  ");
			einlage_in_euro = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Zinssatz (p. a.)  :  ");
			zinssatz = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Anfangsjahr       :  ");
			anfangsjahr = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("\nJahr  Wert am Jahresanfang   Zinsen pro Jahr   Wert am Jahresende\n");
			
			do 
			{
				zinsen = einlage_in_euro * zinssatz / 100;
				wert_am_jahresanfang = einlage_in_euro; // Das Kapital für die Ausgabe merken
				einlage_in_euro = einlage_in_euro + zinsen; // Wert am Jahresende, da Einlage in Euro das Kapital ist
				
				Console.WriteLine("{0}        {1:F2}	         {2:F2}            {3:F2}    ", anfangsjahr, wert_am_jahresanfang, zinsen, einlage_in_euro);
				anfangsjahr++; // Jeden Schleifendurchlauf das Jahr um eins erhöhen
			}
		
			
			while (einlage_in_euro <= 1000000);
			
			
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}