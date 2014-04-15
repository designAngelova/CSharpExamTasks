using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Illuminati
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<char> letters = new List<char>();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                letters.Add(input[i]);
            }
            for (int i = 0; i < letters.Count; i++)
			{


                switch (letters[i])
                {
                    case 'A':
                    case 'a': sum += 65; count++; break;
                    case 'E':
                    case 'e': sum += 69; count++; break;
                    case 'I':
                    case 'i': sum += 73; count++; break;
                    case 'O':
                    case 'o': sum += 79; count++; break;
                    case 'U':
                    case 'u': sum += 85; count++; break;

                }
                
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }

