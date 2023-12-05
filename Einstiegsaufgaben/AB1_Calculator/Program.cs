
class Einstiegsaufgabe
{

    public static void Main(string[] args)
    {    
        int zahl1, zahl2, summe, produkt, quotient, rest;
        summe = 0;
        produkt = 0;
        quotient = 0;
        rest = 0;

        Console.Write("Bitte die erste Zahl eingeben: ");
        zahl1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Bitte die zweite Zahl eingeben: ");
        zahl2 = Convert.ToInt32(Console.ReadLine());

        summe = zahl1 + zahl2;
        produkt = zahl1 * zahl2;
        quotient = zahl1 / zahl2;
        rest = zahl1 % zahl2;

        Console.WriteLine("Die Summe der zwei Zahlen lautet: {0} \n", summe);
        Console.WriteLine("Das Produkt der zwei Zahlen lautet: {0} \n", produkt);
        Console.WriteLine("Der Quotient der zwei Zahlen lautet: {0} \n", quotient);
        Console.WriteLine("Der Rest der zwei Zahlen lautet: {0} \n", rest);

        Console.Write("Press any key to continue... \n");
        
        Console.ReadKey(true);
    }
}
