using System;

namespace Körpergewicht_Teil_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int körpergröße, normalgewicht;
			
			Console.WriteLine("GEWICHTSBERECHNUNG\n");
			
			Console.Write("Geben Sie bitte Ihre Körpergröße in cm ein:  ");
			körpergröße = Convert.ToInt32(Console.ReadLine());
			
			normalgewicht = körpergröße - 100;
				
			Console.WriteLine("\nIhr Normalgewicht beträgt {0} kg\n", normalgewicht);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}