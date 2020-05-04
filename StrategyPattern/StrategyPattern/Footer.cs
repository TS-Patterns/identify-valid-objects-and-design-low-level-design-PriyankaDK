using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class Footer:  DocumentPart
    {
        public override void Converter(IDocumentConverter con)
        {
           con.ConvertFooter(this);
        }
    }
}
