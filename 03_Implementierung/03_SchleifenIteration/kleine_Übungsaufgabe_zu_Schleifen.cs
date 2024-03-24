using System;

namespace kleine_Übungsaufgabe_zu_Schleifen
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// PDF IFB10 Switch lesen: Hier nutze ich eine offene kopfgesteuerte Schleife + switch case
			
			int Aufgabe, x, y, z, a, b, c, d;
			
			Console.WriteLine("Bitte wählen Sie eine Aufgabe, die ausgeführt werden soll (1 - 7):\n");
			Aufgabe=Convert.ToInt16(Console.ReadLine());
			                        
			                        switch(Aufgabe)
			                        {
			                        		
			                        	case 1:
			                        		
			                        		x= 13;
			                        		
			                        		while (x < 30) //Erste Zeile
			                        		{
			                        			Console.Write(x+" ");
			                        			x=x+4;
			                        		}
			                        		
			                        		break;
			                        		
			                        	case 2:
			                        		
			                        		y= 2; // Zweite Zeile
			                        		
			                        		Console.WriteLine();
			                        		
			                        		while (y > -5)
			                        		{
			                        			Console.Write(y+" ");
			                        			y=y-1;
			                        		}
			                        		
			                        		break;
			                        		
			                        	case 3:
			                        		
			                        		z=2000; //Dritte Zeile
			                        		
			                        		Console.WriteLine();
			                        		
			                        		while (z < 7000)
			                        		{
			                        			Console.Write(z+" ");
			                        			z=z+1000;
			                        		}
			                        		
			                        		break;
			                        		
			                        	case 4:
			                        		
			                        		a=5; //Vierte Zeile
			                        		
			                        		Console.WriteLine();
			                        		
			                        		while (a < 14)
			                        		{
			                        			Console.Write("Z"+a+" ");
			                        			a=a+2;
			                        		}
			                        		
			                        		break;
			                        		
			                        	case 5:
			                        		
			                        		b=1; //Fünfte Zeile
			                        		
			                        		Console.WriteLine();
			                        		
			                        		while (b < 4)
			                        		{
			                        			Console.Write("ab"+b+" ");
			                        			b=b+1; // oder man kann auch b++ schreiben;
			                        		}
			                        		
			                        		break;
			                        		
			                        	case 6:
			                        		
			                        		c=2; //Sechste Zeile
			                        		
			                        		Console.WriteLine();
			                        		
			                        		while (c < 24)
			                        		{
			                        			Console.Write("c"+c+" "); //Das Programm liest zuerst diesen Befehl und geht unten weiter
			                        			c=c+1;
			                        			Console.Write("c"+c+" "); //Hier geht es als Zweites und fängt dann die Schleife natürlich wieder von vorne an
			                        			c=c+9;
			                        		}
			                        		
			                        		break;
			                        		
			                        	case 7:
			                        		
			                        		d=13; //Siebte Zeile
			                        		
			                        		Console.WriteLine();
			                        		
			                        		while (d < 46)
			                        		{
			                        			Console.Write(d+" ");
			                        			
			                        			if (d == 21)
			                        			{
			                        				d=d+12;
			                        			}
			                        			
			                        			else
			                        			{
			                        				d=d+4;
			                        			}
			                        			
			                        		}
			                        		
			                        		break;
			                        		
			                        	default:
			                        		Console.WriteLine("Sie haben keine gültige Aufgabennummer eingegeben");
			                        		break;
			                        }
			                       			Console.WriteLine();
			                        		Console.Write("\nPress any key to continue . . . ");
			                        		Console.ReadKey(true);
			      }
	}
}