using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    interface IPrinter
    {
        void Print(string text);
    }

    class OldPrinter
    {
        public void PrintText(string text)
        {
            Console.WriteLine("Печать: " + text);
        }
    }

    class PrinterAdapter : IPrinter
    {
        private OldPrinter printer = new OldPrinter();

        public void Print(string text)
        {
            printer.PrintText(text);
        }
    }
}
