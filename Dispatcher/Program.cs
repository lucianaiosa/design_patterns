using System;
using System.Collections.Generic;

namespace Dispatcher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Poll poll = new Poll();
            List<IAnimal> animals = new List<IAnimal>
            {
              new Dog(),
              new Cat(),
              new Dog()
            };
            animals.ForEach(x => {
                poll.DoPoll(x);
            });
        }
    }
}
