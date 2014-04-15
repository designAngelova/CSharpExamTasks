using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Cinema
    {
        static void Main()
        {
            //input
            string input = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double cols = double.Parse(Console.ReadLine());
            double sum = 0;
            //logic
            if (input == "Premiere")
            {
                sum = (rows * cols) * 12;
            }
            else if (input == "Normal")
            {
                sum = (rows * cols) * 7.5;
            }
            else
            {
                sum = (rows * cols) * 5;
            }
            Console.WriteLine("{0:0.00 leva}", sum);
        }
    }

