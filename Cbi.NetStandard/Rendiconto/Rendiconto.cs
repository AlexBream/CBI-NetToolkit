
using System;
using System.Collections.Generic;
using System.Text;

namespace Cbi.Core.Rendiconto
{
    public class Rendiconto
    {
        public Rendiconto(Header header)
        {
            this.Header = header;
        }

        public Header Header { get; set; }

        public SaldoInziale SaldoInziale { get; set; }

        public Footer Footer { get; set; }

    }

}
