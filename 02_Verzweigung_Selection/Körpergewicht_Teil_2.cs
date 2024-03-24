using System;

namespace Körpergewicht_Teil_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double idealgewicht_mann, idealgewicht_frau, körpergröße, normalgewicht;
			char geschlecht;
			
			Console.WriteLine("GEWICHTSBERECHNUNG\n");
			
			Console.Write("\nGeben Sie bitte Ihre Körpergröße in cm ein:  ");
			körpergröße = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Sind Sie ein Mann oder eine Frau (m/w):  ");
			geschlecht = Convert.ToChar(Console.ReadLine());
			
			normalgewicht = körpergröße - 100;
			
			Console.WriteLine("\nIhr Normalgewicht beträgt {0} kg", normalgewicht);
			
			if (geschlecht == 'm')
			{
				idealgewicht_mann = (körpergröße - 100) * 0.9;
				Console.WriteLine("Ihr Idealgewicht beträgt {0} kg", idealgewicht_mann);
			}
			else if (geschlecht == 'w')
			{
				idealgewicht_frau = (körpergröße - 100) * 0.85;
				Console.WriteLine("Ihr Idealgewicht beträgt {0} kg\n", idealgewicht_frau);
			}
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
		
		}
		
	}
}