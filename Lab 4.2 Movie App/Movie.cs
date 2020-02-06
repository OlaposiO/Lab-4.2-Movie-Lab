using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4._2_Movie_App
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public Movie(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }


        //private string title;
        //private string genre;
        //public string Title { get => title; set => title = value; }
        //public string Genre { get => genre; set => genre = value; }

        //public Movie(string title, string genre)
        //{
        //    Title = title;
        //    Genre = genre;
        //}
    }
}
