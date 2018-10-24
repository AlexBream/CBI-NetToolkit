using Cbi.Core.Interfaces;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cbi.Core
{
    [FixedLengthRecord()]
    public abstract class TipoRecordBase: ITipoRecord
    {
        [FieldFixedLength(1)]
        public string Filler1 { get; set; }

        [FieldFixedLength(2)]
        public string TipoRecord { get; set; }
    }
}
