
    class Program
    {
        static void Main()
        {
            double Artikelanzahl, Einzelpreis, Gesamtpreis, Rabattsatz, Endpreis, Rabattbetrag;
            
            Console.WriteLine("Rabattberechnung");
            
            Console.WriteLine("Artikelanzahl eingeben:");
            Artikelanzahl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Einzelpreis eingeben:");
            Einzelpreis = Convert.ToDouble(Console.ReadLine());
            Gesamtpreis = Einzelpreis * Artikelanzahl;
            if (Gesamtpreis < 500)
            {
                Rabattsatz = 0;
            }
            else if
             (Gesamtpreis < 1000)
            {
                Rabattsatz = 5;
            }
            else if
             (Gesamtpreis < 2500)
            {
                Rabattsatz = 9;
            }
            else if
             (Gesamtpreis < 5000)
            {
                Rabattsatz = 13;
            }
            else if
            (Gesamtpreis < 10000)
            {
                Rabattsatz = 16;
            }
            else 
            {
                Rabattsatz = 18;
            }
            Rabattbetrag = (Gesamtpreis * Rabattsatz) / 100;
            Endpreis = Gesamtpreis - Rabattbetrag;
            Console.WriteLine("Ausgabe");
            Console.WriteLine();
            Console.WriteLine("Verkaufspreis: {0} Euro", Gesamtpreis);
            Console.WriteLine("-{0}% Rabatt.", Rabattsatz);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Zahlungsbetrag {0} Euro", Endpreis);

        }
    }
