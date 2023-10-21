using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int numberOfCommands = int.Parse(Console.ReadLine());

        // Set to store the names of guests
        HashSet<string> guests = new HashSet<string>();

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] command = Console.ReadLine().Split();

            if (command[2] == "going!")
            {
                string name = command[0];
                if (guests.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    guests.Add(name);
                }
            }
            else if (command[2] == "not")
            {
                string name = command[0];
                if (guests.Contains(name))
                {
                    guests.Remove(name);
                }
                else
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
        }
        foreach (var guest in guests)
        {
            Console.WriteLine(guest);
        }
    }
}