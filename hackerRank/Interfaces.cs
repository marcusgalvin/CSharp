using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}

//find the sum of all of a certain number's divisors

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int total = 0;
        for (int i = 1; i <= n; i++)
        {
            //if the input 'n' is divisble by the iterator i
            //add it together
            if (n % i == 0)
            {
                total += i;
            }
        }
        return total;
    }
}

class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}