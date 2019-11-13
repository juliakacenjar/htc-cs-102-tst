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

namespace InterfacesIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();

            // make siome aminals
            Frog frog = new Frog(4,"Bart",true);
            Dog dog = new Dog("Labradoodle", 35, "Pax");
            Duck duck = new Duck(4, "Moo");

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);

            lvAnimals.ItemsSource = Animals;
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }

		private void LvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
			if (selectedAnimal != null)
			{
				selectedAnimal.Speak();
			}
		}
	}
}
