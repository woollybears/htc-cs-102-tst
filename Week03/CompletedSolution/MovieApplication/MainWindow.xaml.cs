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
        public ObservableCollection<Movie> MovieList = new ObservableCollection<Movie>();
        public MainWindow()
        {
            InitializeComponent();
            MovieListview.ItemsSource = MovieList;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submitMovieButton_Click(object sender, RoutedEventArgs e)
        {
            Movie submittedMovie = new Movie(titleTextBox.Text, genreTextBox.Text, Double.Parse(reviewScoreTextBox.Text));
        
           // submittedMovie.Title = titleTextBox.Text;
            //submittedMovie.Genre = genreTextBox.Text;
            //submittedMovie.ReviewScore = Convert.ToDouble(reviewScoreTextBox.Text);
           //submittedMovie.ReviewScore = Double.Parse(reviewScoreTextBox.Text);
            MovieList.Add(submittedMovie);
        }

        private void MovieListview_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie= MovieListview.SelectedItem as Movie;
            selectedMovie.Watch();
        }
    }
}
