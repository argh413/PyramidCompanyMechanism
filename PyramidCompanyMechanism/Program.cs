using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidCompanyMechanism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> peopledic = new Dictionary<int, int>();
            peopledic.Add(1, 0);
            int peoplecount = 1;
            Console.WriteLine($"Month : 0 ||| Population : 1 ||| Benefits : 0");
            for (int month = 1; month < 18; month++)
            {
                int count = 0;
                int benefits = 0;
                for (int j = 1; j <= peoplecount; j++)
                {

                    if (peopledic[j] >= 12)
                    {
                        peopledic[j] += 0;
                    }
                    else
                    {
                        count++;
                        peopledic[j] += 2;
                    }
                    if (peopledic[j] >= 8 || peopledic[j] >= 6)
                    {
                        benefits += 1;
                    }

                }
                count *= 2;
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        peopledic.Add(++peoplecount, 0);

                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Memory is Out !!!!!!!");
                    }

                }
                int sum = 0;
                foreach (var item in peopledic)
                {
                    sum += item.Value;
                }
                sum++;

                Console.WriteLine($"Month : {month} ||| Population : {sum} ||| Benefits : {benefits}");
            }
            Console.ReadKey();
        }
    }
}
