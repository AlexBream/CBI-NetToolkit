using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cbi.Core.Rendiconto
{
    [FixedLengthRecord()]
    public class Footer
    {
        [FieldFixedLength(1)]
        public string Filler1 { get; set; }
        /// <summary>
        /// RH
        /// </summary>
        [FieldFixedLength(2)]
        public string TipoRecord { get; set; }
        [FieldFixedLength(117)]
        public string Filelr { get; set; }
    }
}
