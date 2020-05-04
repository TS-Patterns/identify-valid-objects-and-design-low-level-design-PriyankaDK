using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DocumentPart
    {
        public void Paint()
        {

        }

        public void Save()
        {

        }

        public virtual void Converter(IDocumentConverter con) {
        }
    }
}
