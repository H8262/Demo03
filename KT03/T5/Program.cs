using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[5];

            student[0].Name = "Timo";
            student[0].Motivation = 9001;

            student[1].Name = "Tero";
            student[1].Motivation = 2;

            student[2].Name = "Jorma";
            student[2].Motivation = 71;

            student[3].Name = "Kalle";
            student[3].Motivation = 54;

            student[4].Name = "Matti";
            student[4].Motivation = -2000;

            for(int i = 0; i<5 ; i++)
            {
                Console.WriteLine(student[i].Name + " motivaatio: " + student[i].Motivation);

            }

            Console.ReadLine();

        }
    }
}
