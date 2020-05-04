using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HtmlConverter : IDocumentConverter
    {
        public void ConvertFooter(Footer footer)
        {
            Console.WriteLine("Html footer");
        }

        public void ConvertHeader(Header header)
        {
            Console.WriteLine("Html header");

        }

        public void ConvertHyperLink(HyperLink h)
        {
            Console.WriteLine("Html hyperlink");

        }

        public void ConvertParagraph(Paragraph p)
        {
            Console.WriteLine("Html paragraph");

        }
    }
}
