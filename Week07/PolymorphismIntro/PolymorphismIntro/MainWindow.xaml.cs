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

            Frog frog = new PolymorphismIntro.Frog(1,"Dart",true, 20);
            Dog dog = new PolymorphismIntro.Dog("Labradoodle", 35, "Pax", 51);
            Duck duck = new PolymorphismIntro.Duck(12, "Kevin", 7);
            Frog frog2 = new PolymorphismIntro.Frog(5, "Crazzy", false, 2);
            Dog dog2 = new PolymorphismIntro.Dog("Labradoodle", 7, "Sophie", 5);
            Duck duck2 = new PolymorphismIntro.Duck(39, "Obamuck", 500);


            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(frog2);
            Animals.Add(dog2);
            Animals.Add(duck2);

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
            Animal.CoolInformation(MessageBox.Show );
       
                {

            }
        }
    }
}
