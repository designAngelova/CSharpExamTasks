using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class House
    {
        static void Main()
        {
            int n =  int.Parse(Console.ReadLine());
            char dash = '-';
            char star = '*';
            char line = '|';
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string(dash, (n/2) -i));
                Console.Write(new string(star, i*2+1));
                Console.WriteLine(new string(dash, (n / 2) - i));
            }
            Console.WriteLine(new string(star, n));
            for (int i = 0; i < n; i++)
            {
                Console.Write(line);
                Console.Write(new string(star, n-2));
                Console.WriteLine(line);
            }
        }
    }

