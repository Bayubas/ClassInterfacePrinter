using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementasiPolymorphism
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Printer LaserJet dimension: 12 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing ...");
        }
    }
}