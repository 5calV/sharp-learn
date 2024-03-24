using System;

namespace Urlaubsanspruch_Erweitert
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int alter, grad_der_behinderung;
			double anzahl_der_monate, urlaubstage, urlaubstage_pro_jahr = 24, beschaeftigt_von = 0, beschaeftigt_bis = 13; //bei Formeln mit Division gehört automatisch double rein
			
			Console.WriteLine("ERMITTLUNG DES URLAUBSANSPRUCHES\n");
			
			Console.Write("Alter:                                   ");
			alter = Convert.ToInt32(Console.ReadLine());
			
			do // Falsche Eingabe des Anfangsmonats abfangen
				
			{
				Console.Write("Beschäftigt von (Monat):                 ");
				beschaeftigt_von = Convert.ToDouble(Console.ReadLine());
				
				if (beschaeftigt_von < 1 || beschaeftigt_von > 12)
					
				{
					Console.Write("\a");  												// \a gibt einen Ton aus 
					Console.SetCursorPosition(0,3);										// setzt den Cursor in die Anfangsposition der 4. Zeile
					Console.Write("                                                ");	// Überschreiben der falschen Eingabe
					Console.SetCursorPosition(0,3);										// Cursor zurück an die selbe Postion setzen
				}
				
			}
			
			while (beschaeftigt_von < 1 || beschaeftigt_von > 12);
			
			
			do // Falsche Eingabe des Anfangsmonats abfangen
				
			{
				Console.Write("Beschäftigt bis (Monat):                 ");
				beschaeftigt_bis = Convert.ToDouble(Console.ReadLine());
				
				if (beschaeftigt_bis < 1 || beschaeftigt_bis > 12)
					
				{																		//Console.WriteLine("Falsche Eingabe \a"");
					Console.Write("\a"); 												// \a gibt einen Ton aus
					Console.SetCursorPosition(0,4);
					Console.Write("                                                 "); // Falscheingabe überschreiben
					Console.SetCursorPosition(0,4);	
				}
				if (beschaeftigt_bis < beschaeftigt_von) 								// Der Wert für "Beschäftigt von" muss kleiner als der Wert von "Beschäftigt bis" sein
				
				{																		// Console.Write("Der Endmonat muss größer als der Anfangsmonat sein. \a");
					Console.Write("\a");												// \a gibt einen Ton aus
					Console.SetCursorPosition(0,4);
					Console.Write("                                                 "); // Falscheingabe überschreiben
					Console.SetCursorPosition(0,4);
					
				}	
				
			}
			
			while (beschaeftigt_bis < 1 || beschaeftigt_bis > 12 || beschaeftigt_bis < beschaeftigt_von);
			
			Console.Write("Grad der Behinderung in Prozent:         ");
			grad_der_behinderung = Convert.ToInt32(Console.ReadLine());
			
			if (alter < 18)
				
			{
				urlaubstage_pro_jahr = 30;
			}
			
			else if (alter >= 55)
				
			{
				urlaubstage_pro_jahr = 26;
			}
			
			else
				
			{
				urlaubstage_pro_jahr = 24;
			}
			
			if (grad_der_behinderung >= 50)
				
				//urlaubstage_pro_jahr = urlaubstage_pro_jahr + 5;	
			{
				urlaubstage_pro_jahr +=5;
			}
			
			anzahl_der_monate = (beschaeftigt_bis - beschaeftigt_von) + 1;
			
			// Fehler bei der Eingabe von 20 Jahre, Monat 1, Monat 6, 60 Prozent. Die Berechnung ergibt 14,5 und es muss hier auf 15 aufgerundet werden! 
			
			urlaubstage = Math.Ceiling(urlaubstage_pro_jahr / 12 * anzahl_der_monate); // Math.Ceiling rundet auf den nächsten ganzzählogen Wert auf, während Math.Round abrunden würde.
			
			Console.WriteLine("\nDer Urlaubsanspruch beträgt {0} Tage.\n", urlaubstage);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}