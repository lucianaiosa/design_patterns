using System;

namespace DataMapper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1, "Lucia", false);
            Console.WriteLine(customer.Name);
        }
    }
}
