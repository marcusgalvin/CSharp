using System;

namespace TestFile
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Size: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Array Numbers: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] tempArray = arr;


            //loop
            foreach (int value in tempArray)
            {
                Console.WriteLine("starting arr: ");
                Console.WriteLine(value + " ");
            }

            Array.Reverse(tempArray);

            foreach (int value in tempArray)
            {
                Console.WriteLine(value + " ");
            }
            

        }
    }
}
