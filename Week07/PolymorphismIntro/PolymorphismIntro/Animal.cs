using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolymorphismIntro
{
    public class Animal
    {
        public int Height { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }
        public virtual void Speak()
        {
            MessageBox.Show("");
        }
        public virtual void CoolInformation()
        {
            MessageBox.Show("");
        }

        internal static void CoolInformation(Func<string, string, MessageBoxButton, MessageBoxImage, MessageBoxResult, MessageBoxOptions, MessageBoxResult> show)
        {
            throw new NotImplementedException();
        }
    }
}
