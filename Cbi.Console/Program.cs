using Cbi.Engine.Rendiconto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CbiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new RendicontoEngine();
            var fileName = @"C:\Temp\Cbi\TestRnd.txt";
            var collection = engine.ReadFile(fileName);

            foreach (var item in collection)
            {
                Console.WriteLine(item.Header.NomeSupporto);
            }
            Console.Read();
        }
    }
}
