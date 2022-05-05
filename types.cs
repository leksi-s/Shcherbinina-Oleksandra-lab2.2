class Paper : Garbage
{
    public List<Paper> papertypes { get; set; } = new List<Paper>();
    public Paper(string type, int size, string name) : base(type, size, name) { }
}

class Plastic : Garbage
{
    public Plastic(string type, int size, string name) : base(type, size, name) { }
}

class Glass : Garbage
{
    public Glass(string type, int size, string name) : base(type, size, name) { }
}

class Metal : Garbage
{
    public Metal(string type, int size, string name) : base(type, size, name) { }
}