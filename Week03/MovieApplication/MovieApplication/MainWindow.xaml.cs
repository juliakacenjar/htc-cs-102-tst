using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Movie> MovieList = new ObservableCollection<Movie>();

        public MainWindow()
        {
            InitializeComponent();
            MovieListView.ItemsSource = MovieList;
        }

      

        private void submit_Click(object sender, RoutedEventArgs e)
        {
           
            Movie submittedMovie = new Movie(MovieTitle.Text, MovieGenre.Text, Convert.ToDouble(MovieReviewScore.Text), MovieDirector.Text, Convert.ToInt32(MovieLegnth.Text), MovieamountOfWoollyBearLikeness.Text);

            MovieList.Add(submittedMovie);
            //submittedMovie.Title = MovieTitle.Text;
            //submittedMovie.Genre = MovieGenre.Text;
           // submittedMovie.ReviewScore = Convert.ToDouble(MovieReviewScore.Text);

            //submittedMovie.DisplayInformation();

            MovieTitle.Clear();
            MovieGenre.Clear();
            MovieReviewScore.Clear();
            MovieDirector.Clear();
            MovieLegnth.Clear();
            MovieamountOfWoollyBearLikeness.Clear();
        }

      /*  private void MovieListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        */
        private void MovieListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = MovieListView.SelectedItem as Movie;

            selectedMovie.DisplayInformation();
        }
    }
}
