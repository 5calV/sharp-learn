
class geschichte
{
    static void Main(string[] args)
    {

        string lebewesen, farbe, teil, verb, name;

        Console.WriteLine("Geschichtenerzähler\n");

        Console.Write("Nenne eine Farbe:       ");
        farbe = Console.ReadLine();

        Console.Write("Nenne ein Lebewesen:    ");
        lebewesen = Console.ReadLine();

        Console.Write("Nenne ein Verb:         ");
        verb = Console.ReadLine();

        Console.Write("Nenne einen Körperteil: ");
        teil = Console.ReadLine();

        Console.Write("Nenne einen Namen:      ");
        name = Console.ReadLine();

        Console.WriteLine("\n\nEs war einmal ein {0}.", lebewesen);
        Console.WriteLine("Er hatte einen {0}en {1}.", farbe, teil);
        Console.WriteLine("Auf dem Weg zur Schule sah er {0}.", name);
        Console.WriteLine("Da musste der {0} vor Freude so {1},",lebewesen, verb);
        Console.WriteLine("dass sein {0} wackelte und {1} ", teil, name ); 
        Console.WriteLine("auch ganz {0} wurde.", farbe);

        Console.ReadKey();






























    }
}