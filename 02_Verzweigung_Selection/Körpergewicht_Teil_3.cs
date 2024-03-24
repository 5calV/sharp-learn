using System;

namespace Körpergewicht_Teil_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double idealgewicht_mann, idealgewicht_frau, körpergröße, normalgewicht, aktuelles_gewicht;
			char geschlecht;
			
			Console.WriteLine("GEWICHTSBERECHNUNG\n");
			
			Console.Write("\nGeben Sie bitte Ihre Körpergröße in cm ein:  ");
			körpergröße = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Sind Sie ein Mann oder eine Frau (m/w):  ");
			geschlecht = Convert.ToChar(Console.ReadLine());
			
			Console.Write("Wie viel wiegen Sie aktuell?  ");
			aktuelles_gewicht = Convert.ToDouble(Console.ReadLine());
			
			normalgewicht = körpergröße - 100;
			
			Console.WriteLine("\nIhr Normalgewicht beträgt {0} kg.", normalgewicht);
			
			if (geschlecht == 'm')
			{
				idealgewicht_mann = (körpergröße - 100) * 0.9;
				Console.WriteLine("Ihr Idealgewicht beträgt {0} kg.",idealgewicht_mann);
				if (aktuelles_gewicht > idealgewicht_mann)
				{
					Console.WriteLine("Sie haben {0} kg Übergewicht.", aktuelles_gewicht - idealgewicht_mann);				
				} 
				else
				Console.WriteLine("Sie haben {0} kg Untergewicht.", idealgewicht_mann - aktuelles_gewicht);		
			}
			else if (geschlecht == 'w')
			{
				idealgewicht_frau = (körpergröße - 100) * 0.85;
				Console.WriteLine("Ihr Idealgewicht beträgt {0} kg", idealgewicht_frau);
				if (aktuelles_gewicht > idealgewicht_frau)
				{
					Console.WriteLine("Sie haben {0} kg Übergewicht.", aktuelles_gewicht - idealgewicht_frau);				
				} 
				else
				Console.WriteLine("Sie haben {0} kg Untergewicht.", idealgewicht_frau - aktuelles_gewicht);	
			}
		
		Console.Write("\nPress any key to continue . . . ");
		Console.ReadKey(true);
		
		}
		
	}
}