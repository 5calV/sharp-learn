using System;

namespace Lottogewinn
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double lottogewinn_in_euro = 0, kapital_am_anfang, kapital_am_ende = 0, verzinsung;
			int monat = 1, monatliche_rente;
			
			Console.WriteLine("Wie lange reicht ein Lottogewinn, um davon zu leben?");
			
			Console.Write("\nLottogewinn in Euro   :  ");
			lottogewinn_in_euro = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Verzinsung (p. a.)    :  ");
			verzinsung = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Monatliche Rente       :  ");
			monatliche_rente = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("\nMonat  Kapital am Anfang   Zinsen   monatliche Rente  Kapital am Ende\n");
			
			do 
			{
				verzinsung = lottogewinn_in_euro * verzinsung / 100;
				kapital_am_anfang = lottogewinn_in_euro; 
				lottogewinn_in_euro = lottogewinn_in_euro + verzinsung; 
				kapital_am_ende = kapital_am_anfang + verzinsung + monatliche_rente;
				
				Console.WriteLine("{0}      {1:F2}	  {2:F2}      {3:F2}   {4:F2} ", monat, kapital_am_anfang, verzinsung / 12 , monatliche_rente, kapital_am_ende);
				monat++; // Jeden Schleifendurchlauf das Jahr um eins erhöhen
			}
		
			
			while (kapital_am_ende <= 5000);
			
			
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}