using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Worker
    {
        public IPrinter printer;

        public Worker(IPrinter printer)
        {
            this.printer = printer;
        }

        public void MakeJob()
        {
            printer.Print();
        }
    }
}
