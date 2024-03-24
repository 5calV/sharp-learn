using System;

namespace Schaltjahrermittlung
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int jahr;
			bool schaltjahr = false; 
			
			Console.Write("Geben Sie das gewünschte Jahr ein:  ");
			jahr = Convert.ToInt32(Console.ReadLine());
			
			if (jahr % 4 == 0)
				
			{
				schaltjahr = true;
			}
			
			if (jahr % 400 == 0)
				
			{
				schaltjahr = true;
			}
			
			if (jahr % 100 == 0)
				
			{
				schaltjahr = false;
			}
			
			if (schaltjahr == true)
				
			{
				Console.WriteLine("\nDas Jahr {0} ist ein Schaltjahr!\n", jahr);
			}
			
			else 
			
			{
				Console.WriteLine("\nDas Jahr {0} ist kein Schaltjahr!\n", jahr);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}