using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2._2___
{
     class GarbageName
    {
        public List<Sorting> type { get; set; }
        public GarbageName()
        {
            type = new List<Sorting>();
        }

        public void AddGarbage(Sorting sorting)
        {
            type.Add(sorting);
        }

        public void Content()
        {
            foreach(var sorting in type)
                Console.WriteLine(sorting.ToString());
        }

        public void SortByType(string gtype)
        {
            
            var temp_type = type[0];
           for(int i = 0; i < type.Count; i++)
            {
                for (int j = 0; j < type.Count-1; j++)
                {
                    if (!type[j].Type.Equals(gtype)  && type[j + 1].Type.Equals(gtype))
                    {
                        temp_type = type[j];
                        type[j] = type[j + 1];
                        type[j + 1] = temp_type;
                    }
                }
            }
               
            
        }

        public void SortBySize(int size)
        {
            var temp_type = type[0];
            for (int i = 0; i < type.Count; i++)
            {
                for (int j = 0; j + 1 < type.Count; j++)
                {
                    if (!type[j].Size.Equals(size) && type[j + 1].Size.Equals(size))
                    {
                        temp_type = type[j];
                        type[j] = type[j + 1];
                        type[j + 1] = temp_type;
                    }
                }
            }
        }

        }
    }

