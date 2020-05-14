using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementasiPolymorphism
{
    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer Windows printing... ");
        }
    }
}