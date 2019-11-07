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

namespace PolymorphismIntro
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

            Frog frog = new PolymorphismIntro.Frog(1,"Dart",true);
            Dog dog = new PolymorphismIntro.Dog("Labradoodle", 35, "Pax");
            Duck duck = new PolymorphismIntro.Duck(12, "Kevin");

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
    }
}
