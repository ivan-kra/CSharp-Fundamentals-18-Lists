using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] inputArrays = Console.ReadLine().Split('|').Reverse().ToArray();
        List<int> result = new List<int>();

        foreach (string array in inputArrays)
        {
            int[] numbers = array.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            result.AddRange(numbers);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}