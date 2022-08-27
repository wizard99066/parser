using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parser
{
    public class RtfParser : FileParser
    {
        public override string ParseFormat { get => ".rtf"; }
        public RtfParser(string fileName) : base(fileName)
        {
        }
        public override void Open()
        {
            Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName} был открыт");
        }
        public override void Read()
        {
            Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName} был прочитан");
        }
        public override void Analize()
        {
            Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName} был проанализирован");
        }
        public override void Close()
        {
            Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName} был закрыт");
        }
    }
}
