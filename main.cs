using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2._2___
{
     class main
    {
        static void Main(string[] args)
        {
            GarbageName garbageName = new GarbageName();
            Sorting[] sortings =
            {
                new Sorting("paper", 1,"papersheet"),
                new Sorting("paper", 3,"box"),
                new Sorting ("plastic", 2, "plastic box"),
                new Sorting ("plastic", 3, "plastic bottle"),
                new Sorting("plastic", 1, "plastic wrap"),
                new Sorting("plastic", 1, "plastic bag"),
                new Sorting("metal", 2,"metal can"),
                new Sorting("glass", 3, "glass bottle")
            };

            Console.WriteLine("types of sorting materials:");
     
            for (int i=0;i<sortings.Length;i++)
            {
                Console.WriteLine ($"{i+1}. " + sortings[i]);
            }

            Console.WriteLine("what do you want to sort? if you want to stop, just tap 0.");
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("write a number: ");
                if (number < 0 || number > sortings.Length)
                {
                    Console.WriteLine("input the right number.");
                    continue;
                }
                    

                if (number == 0)
                    break;
                garbageName.AddGarbage(sortings[number - 1]);
            }
            Console.WriteLine("you want to sort:");
            garbageName.Content();

            int number2;
            while (true)
            {
                Console.WriteLine("you want to sort it by:\n 1.type\n 2.size");
                 number2 = int.Parse(Console.ReadLine());
                if (number2 > 2 || number2 < 1)
                {
                    Console.WriteLine("input the right number!");
                    continue;
                }
                else
                    break;
            }
            switch (number2)
            {
                case 1:
                    Console.WriteLine("you chase to sort by type.");
                    garbageName.SortByType("paper");
                    garbageName.SortByType("plastic");
                    garbageName.SortByType("glass");
                    garbageName.SortByType("metal");
                    garbageName.Content();
                  
                    break;
                case 2:
                    Console.WriteLine("you chase to sort by size.");
                    garbageName.SortBySize(1);
                    garbageName.SortBySize(2);
                    garbageName.SortBySize(3);
                    garbageName.Content();
                    break;
            }

           
        }
    }
}
