using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism._1
{
    class canon : printerwindows
    {
        public override void show()
        {
            Console.WriteLine("canon display dimension : 9.5*12");
        }
        public override void print()
        {
            Console.WriteLine("canon printer printing.....");
        }
    }
}
