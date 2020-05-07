using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism._1
{
   class Epson : printerwindows

    {
        public override void show()
        {
            Console.WriteLine("epson display dimension : 10*11");
        }
        public override void print()
        {
            Console.WriteLine("epson printer printing.....");
        }
    }
}
