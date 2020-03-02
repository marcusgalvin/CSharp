using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] elementsA)
    {
        elements = elementsA;
    }

    public void computeDifference()
    {
        int maxNumber = elements.Max();
        int minNumber = elements.Min();
        maximumDifference = maxNumber - minNumber;
        // Console.WriteLine(maximumDifference);
    }



} // End of Difference Class