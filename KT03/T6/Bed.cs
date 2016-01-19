using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Bed
    {
        public string Color { get; set; }
        public int Comfort { get; set; } //from 1 to 10

        public void PrintData()
        {
            Console.WriteLine("Stats: ");
            Console.WriteLine("- color: " + Color);
            Console.WriteLine("- comfort: " + Comfort);

        }
    }
}
