class Garbage
{
    public string Type { get; set; }
    public int Size { get; set; }
    public string Name { get; set; }

    public Garbage(string type, int size, string name)
    {
        Type = type;
        Name = name;
        Size = size;
    }

    public override string ToString()
    {
        return $"{Type}   size: {Size}  name: {Name}";
    }


}

