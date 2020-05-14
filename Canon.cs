using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementasiPolymorphism
{
    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Printer Canon dimension: 10 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }
}