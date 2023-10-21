using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> wagons = ReadWagons();
        int maxCapacity = int.Parse(Console.ReadLine());

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandArgs = command.Split();
            if (commandArgs[0] == "Add")
            {
                int passengersToAdd = int.Parse(commandArgs[1]);
                wagons.Add(passengersToAdd);
            }
            else
            {
                int passengersToFit = int.Parse(commandArgs[0]);
                FitPassengers(wagons, maxCapacity, passengersToFit);
            }
        }

        Console.WriteLine(string.Join(" ", wagons));
    }

    static List<int> ReadWagons()
    {
        string input = Console.ReadLine();
        string[] wagonStrings = input.Split();
        List<int> wagons = new List<int>();

        foreach (string wagon in wagonStrings)
        {
            wagons.Add(int.Parse(wagon));
        }

        return wagons;
    }

    static void FitPassengers(List<int> wagons, int maxCapacity, int passengersToFit)
    {
        for (int i = 0; i < wagons.Count; i++)
        {
            int availableSeats = maxCapacity - wagons[i];
            if (availableSeats >= passengersToFit)
            {
                wagons[i] += passengersToFit;
                break;
            }
        }
    }
}