using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (firstHand.Count > 0 && secondHand.Count > 0)
        {
            int firstPlayerCard = firstHand[0];
            int secondPlayerCard = secondHand[0];

            if (firstPlayerCard > secondPlayerCard)
            {
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);
                firstHand.Add(secondPlayerCard);
                firstHand.Add(firstPlayerCard);
            }
            else if (secondPlayerCard > firstPlayerCard)
            {
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);
                secondHand.Add(firstPlayerCard);
                secondHand.Add(secondPlayerCard);
            }
            else
            {
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);
            }
        }

        if (firstHand.Count > 0)
        {
            int sum = firstHand.Sum();
            Console.WriteLine($"First player wins! Sum: {sum}");
        }
        else
        {
            int sum = secondHand.Sum();
            Console.WriteLine($"Second player wins! Sum: {sum}");
        }
    }
}