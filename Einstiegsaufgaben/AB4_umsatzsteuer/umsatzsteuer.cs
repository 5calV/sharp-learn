
	class Program
	{
		public static void Main(string[] args)
		{
			
			double netto, brutto, ust, ust_betrag;
			
			Console.WriteLine("Geben Sie den Nettopreis in Euro ein: ");
			netto = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Geben Sie die Höhe der Umsatzsteuer in % ein: ");
			ust = Convert.ToDouble(Console.ReadLine());
			
			brutto = netto*(1 + ust/100);
			
			ust_betrag = brutto - netto;

			Console.WriteLine("Bei einem Nettopreis von {0} Euro und einer Umsatzsteuer von {1} % beträgt der Bruttoeinzelpreis {2} Euro", netto, ust, brutto);
			Console.WriteLine("Der Umsatzsteuerbetrag ist {0} Euro", ust_betrag);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
