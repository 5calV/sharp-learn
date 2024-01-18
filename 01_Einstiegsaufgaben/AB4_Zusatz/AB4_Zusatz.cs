
	class Program
	{
		public static void Main(string[] args)
		{
			
			double netto, brutto, bruttogesamt, ust, ust_betrag, anzahl;
			
			Console.WriteLine("Geben Sie die Stückzahl ein: ");
			anzahl = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Geben Sie den Nettoeinzelpreis in Euro ein: ");
			netto = Convert.ToDouble(Console.ReadLine());	
			
			Console.WriteLine("Geben Sie die Höhe der Umsatzsteuer in % ein: ");
			ust = Convert.ToDouble(Console.ReadLine());
			
			brutto = netto * (1 + ust/100);
			
			bruttogesamt = anzahl * netto * (1 + ust/100);
			
			ust_betrag = anzahl * (brutto - netto);
			
			Console.Clear();

			Console.WriteLine("Bei einem Nettoeinzelpreis von {0:0.00} Euro und einer Umsatzsteuer von {1:0.00} % beträgt der Bruttoeinzelpreis {2:0.00} Euro.", netto, ust, brutto);
			Console.WriteLine("Der Bruttogesamtpreis für {2} Stück beträgt {1:0.00} Euro und der Umsatzsteuerbetrag {0:0.00} Euro.", ust_betrag, bruttogesamt, anzahl);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
