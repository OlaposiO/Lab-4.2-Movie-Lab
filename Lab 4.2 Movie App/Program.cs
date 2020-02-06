using System;
using System.Collections.Generic;

namespace Lab_4._2_Movie_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> films = new List<Movie>
           {
               new Movie("John Wick", "action"),
               new Movie("John Wick 2", "action"),
               new Movie("Man of Steel", "superHero"),
               new Movie("End Game", "superHero"),
               new Movie("Star Wars ep 4", "scifi"),
               new Movie("Momento", "thiller"),
               new Movie("The Shinning", "thiller"),
               new Movie("DragonBall Super", "anime"),
               new Movie("Pyscho Pass", "anime"),
               new Movie("5th Element", "scifi"),
           };

            bool ohYeah = true;

            while (ohYeah)
            {
                RunProgram(films);
            }
        }

        private static void RunProgram(List<Movie> movies)
        {
         
            
            Console.WriteLine("What type of movie would you like to watch? \nAction \nSuperhero \nSciFi \nThiller \nAnime \nQuit \n");
            string userInput = Console.ReadLine().ToLower();

            foreach (Movie movie in movies)
            {
                if (movie.Genre == userInput)
                {
                    Console.WriteLine($"{ movie.Title}");
                }
            }
            if (userInput == "quit")
            {
                Console.WriteLine("Have a great day");
                System.Environment.Exit(0);
            }
            
            Console.WriteLine("press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
