using System;

namespace Urlaubsanspruch
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int alter, beschaeftigt_von, beschaeftigt_bis,anzahl_der_monate, grad_der_behinderung;
			double urlaubstage, urlaubstage_pro_jahr = 24; //bei Formeln mit Division gehört automatisch double rein
		
			Console.WriteLine("ERMITTLUNG DES URLAUBSANSPRUCHES\n");
			
			Console.Write("Alter:                                   ");
			alter = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Beschäftigt von (Monat):                 ");
			beschaeftigt_von = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Beschäftigt bis (Monat):                 ");
			beschaeftigt_bis = Convert.ToInt32(Console.ReadLine());
			
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
				
			{
				urlaubstage_pro_jahr +=5;
			}
			
			anzahl_der_monate = (beschaeftigt_bis - beschaeftigt_von) + 1;
			
			urlaubstage = Math.Ceiling(urlaubstage_pro_jahr / 12 * anzahl_der_monate);
			
			Console.WriteLine("\nDer Urlaubsanspruch beträgt {0} Tage.\n", urlaubstage);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}