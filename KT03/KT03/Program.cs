using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT03
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Lada";
            vehicle.Speed = 60;
            vehicle.Tyres = 4;

            vehicle.PrintData();

            vehicle.ToString();

        }
    }
}
