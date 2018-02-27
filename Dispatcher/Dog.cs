using System;

namespace Dispatcher
{
    public class Dog : IAnimal
    {
        public void drink()
        {
            Console.WriteLine("The dog drinks water.");
        }

        public void eat()
        {
            Console.WriteLine("The dog eats meat.");
        }
    }
}
