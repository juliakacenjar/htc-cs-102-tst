using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Frog : Animal
    {
        public bool IsPoisonous;

        public override void Speak()
        {
            MessageBox.Show("Ribbit");
        }
        public override void CoolInformation()
        {
            MessageBox.Show("Frogs are very cool animals.They can absorb water through their skin.They can lay as many as 4000 eggs.Frogs have long back legs and strong webbed feet in order to swim.");
        }
        public Frog() { }

        public Frog(int height, string name, bool isPoisonous, int weight)
        {
            this.IsPoisonous = isPoisonous;
            this.Height = height;
            this.Name = name;
            this.Weight = weight;
        }
    }
}