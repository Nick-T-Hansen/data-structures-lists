using System;
using System.Collections.Generic;

namespace data_structures_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.ForEach(planet => Console.Write($"{planet}" + " "));
            Console.WriteLine();

// Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.ForEach(planet => Console.Write($"{planet}" + " "));
            Console.WriteLine();

// Create another List that contains that last two planet of our solar system.
            List<string> lastPlanets = new List<string>(){"Uranus", "Neptune"};
            foreach(string aplanet in lastPlanets){
                Console.Write($"{aplanet}" + " ");
            }
            Console.WriteLine();

// Combine the two lists by using AddRange().
            planetList.AddRange(lastPlanets);
            foreach(string planet in planetList){
                Console.Write($"{planet}" + " ");
            }
            Console.WriteLine();

// Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            foreach(string planet in planetList){
                Console.Write($"{planet}" + " ");
            }
            Console.WriteLine();

// Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            foreach(string planet in planetList){
                Console.Write($"{planet}" + " ");
            }
            Console.WriteLine();

// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a           new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            foreach(string planet in rockyPlanets){
                Console.Write($"{planet}" + " ");
            }
            Console.WriteLine();

// Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from        the end of planetList.
            planetList.Remove("Pluto");
            foreach(string planet in planetList){
                Console.Write($"{planet}" + " ");
            }
            Console.WriteLine();

            // ------------------------<< Numbers exercise >>------------------------------

            //  Console.WriteLine("Five random integer values:");
            //     for (int ctr = 0; ctr <= 4; ctr++)
            //         Console.Write("{0,15:N0}", rand.Next());
            //     Console.WriteLine();

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                };
            for(int i = 0; i < numbers.Count; i++) {
                if (numbers.Contains(i)) {
                    Console.WriteLine($"{i} is in the list");
                }
                else {
                    Console.WriteLine ($"{i} is not in the list of numbers.");
                }
            }
        }
    }
}