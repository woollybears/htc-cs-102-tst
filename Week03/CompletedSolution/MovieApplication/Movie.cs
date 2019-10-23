using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApplication
{
    public class Movie
    {
        public string Title { get; set; }
        public List<string> Actors;
        public string Genre { get; set; }
        public double ReviewScore { get; set; }

        public void Watch()
        {
            
        }
        public Movie(string title, string genre, double reviewscore)
        {
            Title = title;
            Genre = genre;
            ReviewScore = reviewscore;
        }
    }
}
