using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            // 1. add Jupiter and Saturn 
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            int planetListLength = planetList.Count;

            // 2. Create another List that contains that last two planet of our solar system.
            List<string> lastTwoPlanetsList = new List<string> ();

            // lastTwoPlanetsList.Add(planetList[planetListLength - 1]);
            // lastTwoPlanetsList.Add(planetList[planetListLength - 2]);
            lastTwoPlanetsList.Add("Neptune");
            lastTwoPlanetsList.Add("Pluto");
            
            // checking to make sure that I have the right planets
            foreach(string planet in lastTwoPlanetsList){
                Console.WriteLine(planet);
            }

            // 3. Combine the two lists by using AddRange().
            List<string> planets = new List<string>(planetList);
            planets.AddRange(lastTwoPlanetsList);

            // 4. Insert() Earth and Venus into the list
            planets.Insert(2, "Earth");
            planets.Insert(1, "Venus");

            // 5. Use Add() again to add Pluto to the end of the list.
            planets.Add("Pluto");

            // 6. Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = new List<string>(planets.GetRange(1,4));

            // 7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            rockyPlanets.Remove("Pluto");
        }
    }
}
