using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class WordPrinter:IPrinter, IManage
    {
        public void Print()
        {
            Console.WriteLine("Word doc is print");
        }

        public void Clean()
        {
            //
        }
    }
    public class PdfPrinter:IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Pdf doc is print");
        }
    }

    public class ImagePrinter:IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Image doc is print");
        }
    }
    public class HtmlPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Image doc is print");
        }
    }
}
