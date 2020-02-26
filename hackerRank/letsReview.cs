using System;
using System.Text;

namespace LetsReview
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());


            for (var i = 0; i < t; i++)
            {
                var odd = new System.Text.StringBuilder();
                var even = new System.Text.StringBuilder();

                string s = Console.ReadLine();

                for (var j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        odd.Append(s[j]);
                    } else
                    {
                        even.Append(s[j]);
                    }                   

                }
                Console.WriteLine("odds: " + odd);
                Console.WriteLine("evens: " + even);

            }

        }
    }
}
