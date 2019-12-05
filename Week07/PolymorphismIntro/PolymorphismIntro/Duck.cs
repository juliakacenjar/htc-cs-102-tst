using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Duck : Animal
    {
        public override void Speak()
        {
            MessageBox.Show("Quack");
        }
        public override void CoolInformation()
        {
            
                MessageBox.Show("Ducks are extremely interesting animals. They have the ability to fly. A male duck is called a drake. Ducks have been featured as popular cartoon characters over the years.");
            
        }
        public Duck() { }

        public Duck(int height, string name, int weight)
        {
            this.Height = height;
            this.Name = name;
            this.Weight = weight;
        }
    }
}