﻿namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            myAnimal.MakeSound();
            myDog.MakeSound();
            myCat.MakeSound();
        }
    }
}
