﻿using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie movie1 = new Movie();
            movie1.name = "The Matrix";
            movie1.year = 1999;
            movie1.genres = "Sci";

            Movie movie2 = new Movie("Pulp Fiction", 1994, "Drama");

            Console.WriteLine($"Movie:{movie1.name} Year:{movie1.year} Genre:{movie1.genres}");
            Console.WriteLine($"Movie:{movie2.name} Year:{movie2.year} Genre:{movie2.genres}");



        }
    }


    class Movie
    {
        public string name;
        public int year;
        public string genres;

        public Movie()
        {

        }

        public Movie(string name, int year, string genres)
        {
            this.name = name;
            this.year = year;
            this.genres = genres;
        }
    }

}
