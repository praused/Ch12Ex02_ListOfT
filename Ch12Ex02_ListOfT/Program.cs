﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Ex02_ListOfT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalCollection = new List<Animal>();
            animalCollection.Add(new Cow("Jack"));
            animalCollection.Add(new Chicken("Vera"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            Console.ReadLine();
        }
    }
}
