internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.ReadKey();

        var n = Console.ReadLine();
        for (var i = 0; i < int.Parse(n); i += 2)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }

    }
}

