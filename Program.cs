using System;

namespace ImplementasiPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            Console.WriteLine("Pilih Printer: \n1. Epson\n2. Canon\n3. LaserJet");

            Console.Write("\nMasukan nomor printernya : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            PrinterWindows printer = new PrinterWindows();

            if (pilihPrinter > 0 && pilihPrinter < 4)
            {
                if (pilihPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (pilihPrinter == 2)
                {
                    printer = new Canon();
                }
                else
                {
                    printer = new LaserJet();
                }
            }
            else
            {
                Console.WriteLine("pilihan ini tidak valid \n");
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }

}