using FileHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cbi.Core.Rendiconto
{
    /// <summary>
    /// Codice documento: CBI-RND-001
    /// Versione documento: v.6.05
    /// Utimo aggiornamento: 05-03-2013
    /// Funzione "Rendicontazione saldi e movimenti CC"
    /// Struttura "61" (saldo inziale)
    /// </summary>
    [FixedLengthRecord()]
    public class SaldoInziale: TipoRecordBase
    {
        [FieldFixedLength(117)]
        public string Filler2 { get; set; }


    }
}
