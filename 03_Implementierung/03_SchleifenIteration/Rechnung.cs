using System;

namespace Rechnung
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double einzelpreis, gesamtpreis_netto = 0;
			int artikelmenge;
			
			do
			{
				Console.Write("Bitte Artikelmenge eingeben (0 = Ende):  ");
				artikelmenge= Convert.ToInt32(Console.ReadLine());
				
				if (artikelmenge != 0) // != ist ungleich
				{
					Console.Write("Bitte Einzelpreis eingeben:  ");
					einzelpreis = Convert.ToDouble(Console.ReadLine());
					
					gesamtpreis_netto = gesamtpreis_netto + einzelpreis * artikelmenge;
					
				}
			
			}
			
			while (artikelmenge != 0);
								
			Console.WriteLine("\nGesamtpreis netto            {0:F2} Euro", gesamtpreis_netto);
			Console.WriteLine("+ 19 % Mehrwertsteuer         {0:F2} Euro", gesamtpreis_netto * 0.19);
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("Gesamtpreis brutto           {0:F2} Euro", gesamtpreis_netto * 1.19);
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}