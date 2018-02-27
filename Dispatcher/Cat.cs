using System;

namespace Dispatcher
{
    public class Cat : IAnimal
    {
        public void drink()
        {
            Console.WriteLine("The cat drinks water.");
        }

        public void eat()
        {
            Console.WriteLine("The cat eats meat.");
        }
    }
}
