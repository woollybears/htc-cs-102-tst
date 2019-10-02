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
        public string Random_Sound;
        private string v1;
        private int v2;
        private string dogName;

        public void Bark()
        {
            MessageBox.Show("*Barks in French*");
        }
        public void SayName()
        {
            MessageBox.Show("Hello, my name is " + Name + ".");
        }


        public Dog(string breed, int height, string name, string random_sound)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
            this.Random_Sound = random_sound;
        }

        public Dog(string v1, int v2, string dogName)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dogName = dogName;
        }
    }
}
