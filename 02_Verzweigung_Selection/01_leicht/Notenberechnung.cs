using System;

namespace leicht_Notenberechnung
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int gesamtzahl_klassenarbeit, erreichte_punkte, prozentrechnung;
			string notentext = "";
			
			Console.WriteLine("Eingabedaten:\n");
			
			Console.Write("Gesamtpunktzahl der Klassenarbeit: ");
			gesamtzahl_klassenarbeit = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Erreichte Punkte                 : ");
			erreichte_punkte = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("\nAuswertung:\n");
			
			prozentrechnung = (100 * erreichte_punkte) / gesamtzahl_klassenarbeit;
			
			  if (prozentrechnung >= 92) 
            {
                notentext = "sehr gut";
            }    
            
            else if (prozentrechnung >= 81)
            {
                notentext = "gut";
            }
                
            else if (prozentrechnung >= 67)
            {
                notentext = "befriedigend";
            }
            
            else if (prozentrechnung >= 50)
            {
                notentext = "ausreichend";
            }
            
            else if (prozentrechnung >= 30)
            {
                notentext = "mangelhaft";
            }
            
            else if (prozentrechnung >= 0)
            {
                notentext = "ungenügend";
            }
             
            Console.WriteLine("{0} Punkte bedeuten {1} %." , erreichte_punkte, prozentrechnung );
            Console.WriteLine("Die Note {0} wurde erreicht.", notentext);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}