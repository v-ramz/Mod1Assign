class Program
{
    static void Main(string[] args)
    {

        List<Character> characters = new List<Character>
        {
            new Character { Id = 1, Name = "Luigi", Relationship = "Twin Brother" },
            new Character { Id = 2, Name = "Wario", Relationship = "Archnemesis" },
            new Character { Id = 3, Name = "Princess Peach", Relationship = "Love Interest" }
        };
        int newId = 4;
        bool running = true;
        Console.WriteLine();
        Console.WriteLine("██████╗ ██████╗  ██████╗ ");
        Console.WriteLine("██╔══██╗██╔══██╗██╔═══██╗");
        Console.WriteLine("██████╔╝██████╔╝██║   ██║");
        Console.WriteLine("██╔══██╗██╔══██╗██║   ██║");
        Console.WriteLine("██████╔╝██║  ██║╚██████╔╝");
        Console.WriteLine("╚═════╝ ╚═╝  ╚═╝ ╚═════╝ ");
        Console.WriteLine("\nWelcome To The Bro Management App!\n");
        while (running)
        {
            Console.WriteLine("Please Choose an option!\n");
            Console.WriteLine("1. Add new Bro");
            Console.WriteLine("2. See all Bros");
            Console.WriteLine("3. Exit\n");
            string? options = Console.ReadLine();
            Console.WriteLine();
            switch (options)
            {
                case "1":
                    Console.WriteLine("Adding a new Bro!\n");
                    string? name;
                    Console.WriteLine("Enter the Bro's name.\n");
                    do
                    {
                        name = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(name))
                            Console.WriteLine("You need to enter a name for your Bro.\n");
                        else if (characters.Exists(c => c.Name != null && c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                        {
                            Console.WriteLine("Looks like that Bro is already in here. Try again.\n");
                            name = null;
                        }
                    } while (string.IsNullOrWhiteSpace(name));
                    string? relationship;
                    Console.WriteLine("\nEnter the Bro's relationship to Mario.\n");
                    do
                    {
                        relationship = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(relationship))
                            Console.WriteLine("You need to enter a relationship fro your Bro.\n");
                    } while (string.IsNullOrWhiteSpace(relationship));
                    characters.Add(new Character { Id = newId++, Name = name, Relationship = relationship });
                    Console.WriteLine("\nAll good, they're in! \n\nNew Bro Details:\n");
                    Console.WriteLine($"{newId - 1}: {name}, {relationship}\n");
                    break;
                case "2":
                    Console.WriteLine("Your Bros:\n");
                    foreach (var c in characters)
                    {
                        Console.WriteLine($"{c.Id}, {c.Name}, {c.Relationship}\n");
                    }
                    break;
                case "3":
                    Console.WriteLine("\nExiting, see ya!\n");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Sorry you need to choose a valid option. \n");
                    break;
            }
        }
    }
}
