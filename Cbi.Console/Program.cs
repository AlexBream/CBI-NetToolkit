using Cbi.Engine.Rendiconto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbi.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new RendicontoEngine();
            var fileName = @"C:\Temp\Cbi\TestRnd.txt";
            var r = engine.ReadFile(fileName);

        }
    }
}
