class Program
{
    static void SelectRace()
    {
        string[] NamesOfRace = {"People", "Elves", "Orks", "Goblins", "Dwarfes"};
        WriteSelect(NamesOfRace);
        Console.WriteLine("Choose your Race ");
        int numberRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your Race is: " + NamesOfRace[numberRace-1]);
    }
    static void SelectSex()
    {
        string[] NamesOfSex = {"Male", "Female"};
        WriteSelect(NamesOfSex);
        Console.WriteLine("Choose your Sex ");
        int numberSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your Sex is: " + NamesOfSex[numberSex-1]);
    }
    static void SelectClass()
    {
        string[] NamesOfClass = {"Warrior", "Berzerker", "Magician", "Paladin"};
        WriteSelect(NamesOfClass);
        Console.WriteLine("Choose your Class ");
        int numberClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your Class is: " + NamesOfClass[numberClass-1]);
    }
    static void WriteSelect(string[] args)
    {
        for (int i = 0; i < args.Length-1; i++)
        {
            Console.Write(i+1 + " - " + args[i] + ", ");
        }
        Console.WriteLine(args.Length + " - " + args[args.Length-1] + ".");
    }
    static void Main(string[] args)
    {
        SelectRace();
        SelectSex();
        SelectClass();
    }
}