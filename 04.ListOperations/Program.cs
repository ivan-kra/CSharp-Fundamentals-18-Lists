using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] command = input.Split();
            string action = command[0];

            switch (action)
            {
                case "Add":
                    int numberToAdd = int.Parse(command[1]);
                    numbers.Add(numberToAdd);
                    break;

                case "Insert":
                    int numberToInsert = int.Parse(command[1]);
                    int indexToInsert = int.Parse(command[2]);
                    if (indexToInsert >= 0 && indexToInsert <= numbers.Count)
                    {
                        numbers.Insert(indexToInsert, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "Remove":
                    int indexToRemove = int.Parse(command[1]);
                    if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                    {
                        numbers.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "Shift":
                    int count = int.Parse(command[2]) % numbers.Count;
                    if (command[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstElement = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstElement);
                        }
                    }
                    else if (command[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastElement = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastElement);
                        }
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
