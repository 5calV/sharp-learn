
class rabattRechner {

	public static void Main(string[] args) {

        // Variablen Eingabe
        string produkt = String.Empty;
        double einzelpreis = 0;
        int stueckzahl = 0;
        float rabatt = 0;

        // Variablen Rechnung
        double normalpreis = 0;
        double rabattBetrag = 0;
        double preisNachAbzug = 0;

        // Eingabe Produktname
        Console.WriteLine("Welches Produkt wurde gekauft?\n");
		produkt = Console.ReadLine();

        // Eingabe Einzelpreis
        Console.WriteLine("Was ist der Einzelpreis?\n");
        einzelpreis = Convert.ToDouble(Console.ReadLine());

        // Eingabe stueckzahl
        Console.WriteLine("Wie viel Stück wurden gekauft?\n");
        stueckzahl = Convert.ToInt16(Console.ReadLine());

        // Eingabe Rabatt
        Console.WriteLine("Wie viel Rabatt wollen Sie gewähren?\n");
        rabatt = Convert.ToSingle(Console.ReadLine());

        // Rechnung
        normalpreis = stueckzahl * einzelpreis;

        rabattBetrag = normalpreis * rabatt / 100; // Hier Prozentrechnung
        
        preisNachAbzug = normalpreis - rabattBetrag;

        Console.Clear();

        // Ausgabe
        Console.WriteLine("Der Kunde kauft: " + stueckzahl + " Stück " + produkt + " zu einem Einzelpreis von " + einzelpreis + "€.");
        Console.WriteLine("Der Normalpreis würde " + normalpreis + "€ betragen.");
        Console.WriteLine("Sie gewähren " + rabatt + "% Rabatt.");
        Console.WriteLine("Rabattbetrag:" + rabattBetrag + "€.");
        Console.WriteLine("Somit zahlt der Kunde insgesamt nur " + preisNachAbzug + "€, statt " + normalpreis + "€.");

    }

}
