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
        public string Director { get; set; }
        public int Legnth { get; set;}
        public string AmountOfWoollyBearLikeness { get; set; }
        public string MoviePoster { get; set; }


      public List<string> Actors;

        public Movie(string title, string genre, double reviewScore, string director, int legnth, string amountOfWoollyBearLikeness, string MoviePoster)
        {
            this.Title = title;
            this.Genre = genre;
            this.ReviewScore = reviewScore;
            this.Director = director;
            this.Legnth = legnth;
            this.AmountOfWoollyBearLikeness = amountOfWoollyBearLikeness;
            this.MoviePoster = MoviePoster;
        }

       public void DisplayInformation()
        {
            MessageBox.Show($"Title: {Title} \n Genre: {Genre} \n Review Score: {ReviewScore} \n Director: {Director} \n Legnth: {Legnth} \n Amount of Woolly Bear Likeness: {AmountOfWoollyBearLikeness} \n Movie Poster: {MoviePoster}");
        }
    }
}
