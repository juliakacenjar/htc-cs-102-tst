using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int Height;
        public string Name;
        public string FavoriteColor;
        public string DogsFavToy;

        public void Bark()
        {
            MessageBox.Show(" Bark Bark Bark");
        }
        public void SayName()
        {
            MessageBox.Show("Hello, my name is " + Name);
        }
        public Dog() { }

        public Dog(string breed, int height, string name)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
        }
        
    }
}
