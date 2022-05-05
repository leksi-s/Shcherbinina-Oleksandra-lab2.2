class main
{
    static void Main(string[] args)
    {

        Garbage[] sortings =
        {
                new Garbage("paper", 20,"papersheet/box"),
                new Garbage ("plastic",50, "plastic box/bottle/wrap/bag"),
                new Garbage("metal", 30,"metal can"),
                new Garbage("glass", 40, "glass bottle")
            };

        Console.WriteLine("types of sorting materials:");

        for (int i = 0; i < sortings.Length; i++)
        {
            Console.WriteLine($"{i + 1}. " + sortings[i]);
        }

        Console.WriteLine("what type of garbage do you want to sort?\nif you want to stop write 0.");
        GarbageCollection garbage = new GarbageCollection();
        garbage.AddGarbage();
        garbage.Content();
        Console.WriteLine("\n sorted garbage:");
        garbage.Sort();
    }
}