using System;

namespace trik
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < x.Length; i++)
            {
                string l = x[i] + "";
                if (l.Equals("A"))
                {
                    if (count == 1)
                        count++;
                    else if (count == 2)
                        count--;
                }
                else if (l.Equals("B"))
                {
                    if (count == 2)
                        count++;
                    else if (count == 3)
                        count--;
                }
                else
                {
                    if (count == 1)
                        count += 2;
                    else if (count == 3)
                        count -= 2;
                }
            }
            Console.WriteLine(count);

        }
    }
}
