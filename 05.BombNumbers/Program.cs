using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] bombParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int bombNumber = bombParams[0];
        int bombPower = bombParams[1];

        while (numbers.Contains(bombNumber))
        {
            int bombIndex = numbers.IndexOf(bombNumber);
            int leftIndex = Math.Max(0, bombIndex - bombPower);
            int rightIndex = Math.Min(numbers.Count - 1, bombIndex + bombPower);
            int countToRemove = rightIndex - leftIndex + 1;

            numbers.RemoveRange(leftIndex, countToRemove);
        }

        int sumRemainingNumbers = numbers.Sum();
        Console.WriteLine(sumRemainingNumbers);
    }
}