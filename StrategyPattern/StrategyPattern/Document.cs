using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Document
    {
        List<DocumentPart> _part = new List<DocumentPart>();

        public void Open()
        {
            Console.WriteLine("Open");
        }
        public void Save()
        {
            Console.WriteLine("Save");
        }
        public void Close()
        {
            Console.WriteLine("Close");
        }
        public void Add(DocumentPart part)
        {
            Console.WriteLine("Add");
            _part.Add(part);
        }
        public void Convert(IDocumentConverter docConverter)
        {
            foreach (var part in _part)
            {
                part.Converter(docConverter);
            }

        }
    }
}
