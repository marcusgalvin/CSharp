using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();

//try catch block - cannot use if statements in this algorithm
        try 
        {
            
            int test = int.Parse(S);
            Console.WriteLine(test);
            
        } catch (Exception) {
            Console.WriteLine("Bad String");
        }

    }
}