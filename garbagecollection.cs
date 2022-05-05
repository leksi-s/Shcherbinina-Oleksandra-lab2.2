class GarbageCollection
{
    public List<Garbage> alltypes { get; set; }

    public GarbageCollection()
    {
        alltypes = new List<Garbage>();
    }

    public void AddGarbage()
    {
        int number = 1;
        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Paper paper = new Paper("paper", 20, "papersheet/box");
                    alltypes.Add(paper);
                    continue;

                case 2:
                    Plastic plastic = new Plastic("plastic", 50, "plastic box/bottle/wrap/bag");
                    alltypes.Add(plastic);
                    continue;

                case 3:
                    Metal metal = new Metal("metal", 30, "metal can");
                    alltypes.Add(metal);
                    continue;

                case 4:
                    Glass glass = new Glass("glass", 40, "glass bottle");
                    alltypes.Add(glass);
                    continue;

                case 0:
                    break;

                default:
                    Console.WriteLine("input the right number!");
                    continue;
            }

        }
    }

    public void Sort()
    {
        var sort = from p in alltypes
                            orderby p.Size
                            select p;

        foreach (var p in sort)
            Console.WriteLine($"{p.Type}   size: {p.Size}  name: {p.Name}");
    }

    public void Content()
    {
        foreach (var sorting in alltypes)
            Console.WriteLine(sorting.ToString());
    }

}