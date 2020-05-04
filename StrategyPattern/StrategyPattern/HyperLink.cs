using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HyperLink :DocumentPart
    {
        public override void Converter(IDocumentConverter con)
        {
            con.ConvertHyperLink(this);
        }
    }
}
