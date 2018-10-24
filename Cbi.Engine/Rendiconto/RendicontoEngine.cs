using Cbi.Core.Rendiconto;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cbi.Engine.Rendiconto
{
    public class RendicontoEngine
    {
        readonly MultiRecordEngine engine;
        readonly Type[] recordTypes = { typeof(Header),
            typeof(Footer) };

        public RendicontoEngine()
        {
            engine = new MultiRecordEngine(recordTypes)
            {
                RecordSelector = new RecordTypeSelector(CustomSelector)
            };
        }

        public Core.Rendiconto.Rendiconto[] ReadFile(string fileName)
        {
            var rr = new List<Core.Rendiconto.Rendiconto>();
            var result = engine.ReadFile(fileName);
            Core.Rendiconto.Rendiconto rnd = null;

            var @switch = new Dictionary<Type, Action<object>> {
                { typeof(Header), (row) => { rnd = new Core.Rendiconto.Rendiconto((Header)row); rr.Add(rnd);} },
                { typeof(Footer), (row) => { rnd.Footer = (Footer)row; }},
           };

            foreach (var row in result)
            {
                @switch[row.GetType()](row);
            }

            return rr.ToArray();
        }

        private Type CustomSelector(MultiRecordEngine engine, string row)
        {
            if (row.Length < 3)
                return null;

            var key = row.Substring(0, 3).Trim();

            switch (key)
            {
                case "RH":
                    return typeof(Header);
                case "EF":
                    return typeof(Footer);
                default:
                    return null;
            };

        }
    }
}
