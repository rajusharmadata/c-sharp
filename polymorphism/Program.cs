///polymorphism
using System;

namespace std
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the base class
            Animal myAnimal = new Animal();
            myAnimal.Speak(); // Calls the Speak method of the Animal class. Output: The animal makes a sound.

            // Create an instance of the derived class
            Dog myDog = new Dog();
            myDog.Speak(); // Calls the overridden Speak method of the Dog class. Output: The dog barks.
        }
    }

    // Base class
    public class Animal
    {
        // Virtual method that can be overridden in derived classes
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound."); // Default behavior for the base class
        }
    }

    // Derived class
    public class Dog : Animal
    {
        // Override the Speak method to provide specific behavior for the Dog class
        public override void Speak()
        {
            Console.WriteLine("The dog barks."); // Behavior specific to the Dog class
        }
    }
}