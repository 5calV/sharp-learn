
class Kleinste_Zahl {

    public static void Main(string[] args) {

        Console.WriteLine("Zahlenvergleich");

        int zahl1, zahl2;

        Console.WriteLine("Bitte erste Zahl eingeben:");
        zahl1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bitte zweite Zahl eingeben:");
        zahl2 = Convert.ToInt32(Console.ReadLine());

        if (zahl1 == zahl2) {
            Console.WriteLine(zahl1 + " und " + zahl2 + " sind gleich groß.");
        }
        else if (zahl1 < zahl2) {
            Console.WriteLine(zahl1 + " ist kleiner als " + zahl2);
        }
        else {
            Console.WriteLine(zahl1 + " ist größer als " + zahl2);
        }





    }
}
