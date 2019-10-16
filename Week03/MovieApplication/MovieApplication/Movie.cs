using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApplication
{
    class Movie
    {
        public string Title { get; set; }
        //   public string Title;
        public string Genre { get; set; }
        //public string Genre;
        public double ReviewScore { get; set; }
        //public double ReviewScore;

      public List<string> Actors;

        public Movie(string title, string genre, double reviewScore)
        {
            this.Title = title;
            this.Genre = genre;
            this.ReviewScore = reviewScore;
        }

       public void DisplayInformation()
        {
            MessageBox.Show($"Title: {Title} \n Genre: {Genre} \n Review Score: {ReviewScore} ");
        }
    }
}
