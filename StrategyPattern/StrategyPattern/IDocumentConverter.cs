using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IDocumentConverter
    {
        void ConvertParagraph(Paragraph p);
        void ConvertHyperLink(HyperLink h);
        void ConvertHeader(Header header);
        void ConvertFooter(Footer footer);

    }
}
