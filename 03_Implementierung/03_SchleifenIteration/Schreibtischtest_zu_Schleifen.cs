using System;

namespace Schreibtischtest_zu_Schleifen
{
	class Program
	{
		public static void Main(string[]args)
		{
			
			int a, b, x, p, n, k, s, n2, k2; // Man kann auch hier direkt die Zahlen zuweisen z.B. a= 3, b= 8, x= 0 usw.
			
			// Übung 1
			
			a= 3;
			b = 8;
			x = 0;
			
			while (a<=b)
			{
				x++; //ist dasselbe wie x=x+1, nur kürzer;
				a++; //ist dasselbe wie a=a+1, nur kürzer;
			}
			
			Console.WriteLine("Der Wert von x lautet: {0}", x);
			
			//Übung 2
			
			s=0;
			n2=5;
			k2=1;
			
			while (k2!=n2)
			{
				s=s+k2;
				k2++; //k2=k2+1;
			}
			
			Console.WriteLine("Der Wert von s lautet: {0}", s);
			
			//Übung 3
			
			p=1;
			n=5;
			k=n;
			
			do
			{
				p=p*k;
				k=k-1; //k--;
			}
			
			while (k>0);
			
			
			Console.WriteLine("Der Wert von p lautet: {0}", p);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}