﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Dog : Animal
    {
       // public string Name;
      //  public int Height;
      public string Breed;

        public void Bark()
        {
            MessageBox.Show("Bork");
        }
        //Inherited from Animal
       // public void SayName()
        //{
         //   MessageBox.Show("My name is " + this.Name);
       // }

        public Dog() { }

        public Dog(string breed, int height, string name)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
        }
    }
}