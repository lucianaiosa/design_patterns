using System;

namespace Dispatcher
{
    public class Poll
    {
        public int number { get; set; }
        public string name { get; set; }
        public IAnimal animal { get; set; }

        public void DoPoll(IAnimal animal)
        {
			animal.drink();
        }

        public void DoPoll(Dog dog)
        {
            Console.WriteLine("Animal Type : dog");
        }

        public void DoPoll(Cat cat)
        {
            cat.eat();
        }
    }
}
