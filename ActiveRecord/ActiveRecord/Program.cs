using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveRecord
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
