using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bed bed = new Bed();
            bed.Color = "blue";
            bed.Comfort = 10;

            bed.PrintData();
        }
    }
}
