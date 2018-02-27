using System;

namespace DAO
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
