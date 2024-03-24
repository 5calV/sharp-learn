using System;

namespace Tankrechnung
{
	class Program
	{
		public static void Main(string[] args)
		{
			string benzinart; // string bedeutet text
			double normalbenzinpreis = 1.612; // double bedeutet Zahl mit Komma
			double superbenzinpreis = 1.674;
			double dieselpreis = 1.465;
			double getankte_liter;
			double bruttopreis = 0; // wenn es nicht vorher zugewiesen ist, gibt es einen Compiler-Fehler und damit "= 0" setzen.
			
			Console.Write("Bitte geben Sie Ihre Benzinart (Normalbenzin, Superbenzin oder Diesel) ein:  ");
			
			benzinart = Console.ReadLine(); // keine Konvertierung nötig, weil es als Text gelesen wird.
			
			if (benzinart != "Normalbenzin" && benzinart != "Superbenzin" && benzinart != "Diesel") // != bedeutet "ungleich" während && eine "Und-Verknüpfung" ist.
			{
				Console.Clear();
				Console.WriteLine("Falsche Benzinart eingegeben.");
				Console.Write("Press any key to continue . . . ");
				Console.ReadKey(true);
				return; //Bricht einen Konsolenprogramm ab.
			}
			
			Console.Write("Wie viel Liter haben Sie getankt:   ");
			getankte_liter = Convert.ToDouble(Console.ReadLine());
			
			Console.Clear();
			
			Console.WriteLine("                       Tankrechnung ");
			Console.WriteLine("                      ---------------");
			
			switch (benzinart) //Switch nutzt man bei string (Text), char (ein Zeichen wie z.B. 'm') und bei int (ganze Zahlen).
			{
				case "Normalbenzin":
					Console.WriteLine("Sie haben {0:F2} Liter Normalbenzin zu einem Literpreis in Höhe", getankte_liter);
					Console.WriteLine("von {0:F2} EUR pro Liter getankt.", normalbenzinpreis);
					bruttopreis = normalbenzinpreis * getankte_liter;
					break; // bricht den Case Zweig ab und springt hinter die Switchanweisung.
				case "Superbenzin":
					Console.WriteLine("Sie haben {0:F2} Liter Superbenzin zu einem Literpreis in Höhe", getankte_liter);
					Console.WriteLine("von {0:F2} EUR pro Liter getankt.", superbenzinpreis);
					bruttopreis = superbenzinpreis * getankte_liter;
					break;
				case "Diesel":
					Console.WriteLine("Sie haben {0:F2} Liter Diesel zu einem Literpreis in Höhe", getankte_liter);
					Console.WriteLine("von {0:F2} EUR pro Liter getankt.", dieselpreis);
					bruttopreis = dieselpreis * getankte_liter;
					break; 
			}
			
			Console.WriteLine("\nSie müssen {0:F2} Euro zahlen.\n", bruttopreis); // F2 ist ein Format für 0.00 und \n ist eine neue Zeile.
			
			Console.WriteLine("Nettobetrag:      {0:F2} Euro     ", bruttopreis / 1.19);
			Console.WriteLine("Mehrwertsteuer:   {0:F2} Euro     ", bruttopreis - (bruttopreis / 1.19));
			Console.WriteLine("Bruttobetrag:     {0:F2} Euro     ",bruttopreis);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}