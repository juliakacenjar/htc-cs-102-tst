using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submitMovieButton_Click(object sender, RoutedEventArgs e)
        {
            Movie submittedMovie = new Movie();

            submittedMovie.Title = titleTextBox.Text;
            submittedMovie.Genre = genreTextBox.Text;
            //submittedMovie.ReviewScore = Convert.ToDouble(reviewScoreTextBox.Text);
            submittedMovie.ReviewScore = Double.Parse(reviewScoreTextBox.Text);
        }
    }
}
