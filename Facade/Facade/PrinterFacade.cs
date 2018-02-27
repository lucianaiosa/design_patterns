using System;

namespace Facade
{
    public class PrinterFacade
    {
        public Printer printer;
        public PrinterFacade(String text)
        {
            printer = new Printer();
            printer.color = true;
            printer.sheet = "A4";
            printer.documentType = "PDF";
            printer.text = text;
        }
        public void imprimir()
        {

            printer.printDocument();
        }
    }
}
