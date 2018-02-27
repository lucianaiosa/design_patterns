using System;

namespace Facade
{
    public class Program
    {
        public static void Main(String[] args)
        {
            PrinterFacade facade1 = new PrinterFacade("texto1");
            facade1.imprimir();

            PrinterFacade facade2 = new PrinterFacade("texto2");
            facade2.imprimir();


            Printer i3 = new Printer();
            i3.sheet = "A4";
            i3.color = true;
            i3.documentType = "excel";
            i3.text ="texto 3";
            i3.printDocument();
        }
    }
}
