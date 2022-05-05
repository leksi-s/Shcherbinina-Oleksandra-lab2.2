using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2._2___
{
     class Sorting
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }    

        public Sorting(string gtype, int size, string name)
        {
            this.Type = gtype;
            this.Size = size;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Type}   size: {Size}  name: {Name}";
        }
    }
}
