using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class CrossingSequences
{
    static void Main()
    {
        // input
        BigInteger first = int.Parse(Console.ReadLine());
        BigInteger second = int.Parse(Console.ReadLine());
        BigInteger third = int.Parse(Console.ReadLine());
        int startNumber = int.Parse(Console.ReadLine());
        int interval = int.Parse(Console.ReadLine());
        List<BigInteger> tribonacci = new List<BigInteger>();
        List<BigInteger> spiral = new List<BigInteger>();
        const int range = 20;
        int remover = 2;
        BigInteger sum = 0;
        for (int i = 0; i < range; i++)
        {
            sum = first + second + third;
            first = second;
            second = third;
            third = sum;
            tribonacci.Add(third);
        }
        for (int i = interval; i < range; i++)
        {
            int tmp = startNumber + interval;
            int next = startNumber + interval;
            startNumber = next;
            spiral.Add(startNumber);
        }
       for (int i = 0; i < spiral.Count; i++)
			{
                spiral.Remove(spiral[remover]);
                    remover++;
                
                

			}
       foreach (var index in spiral)
       {
           Console.WriteLine(index);
       }
           
        }

    }

