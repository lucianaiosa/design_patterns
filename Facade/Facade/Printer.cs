using System;

namespace Facade
{
    public class Printer
    {
        public String documentType { get; set; }
        public String sheet { get; set; }
        public bool color { get; set; }
        public String text { get; set; }

       public void printDocument()
        {

            Console.WriteLine("imprimiendo: " + text + ", color: "
            + color + ", tipo: " + documentType + ", hoja: " + sheet);
        }
    }
}

