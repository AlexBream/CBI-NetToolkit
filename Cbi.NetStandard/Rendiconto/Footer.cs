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
    /// Struttura "EF (record di coda)
    /// </summary>
    [FixedLengthRecord()]
    public class Footer: TipoRecordBase
    {
        /// <summary>
        /// Codice ABI della Banca mittente estratti conto; è censita sul Directory
        /// </summary>
        [FieldFixedLength(5)]
        public string AbiMittente { get; set; }

        /// <summary>
        /// codice SIA dell'Impresa destinataria della rendicontazione conti correnti contenuta nel supporto logico; è censita sul Directory;
        /// </summary>
        [FieldFixedLength(5)]
        public string SiaRicevente { get; set; }

        /// <summary>
        /// data di creazione del 'flusso' da parte della Banca mittente nel formato GGMMAA
        /// </summary>
        [FieldFixedLength(6)]
        public string DataCreazioneRaw { get; set; }

        /// <summary>
        /// campo di libera composizione da parte della Banca Mittente; deve essere univoco nell'ambito della data di creazione ed a parità di mittente e ricevente
        /// </summary>
        [FieldFixedLength(20)]
        public string NomeSupporto { get; set; }

        [FieldFixedLength(6)]
        public string Filler2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [FieldFixedLength(7)]
        public int NumeroRendicontazioni { get; set; }

        [FieldFixedLength(30)]
        public string Filler3 { get; set; }

        [FieldFixedLength(7)]
        public int NumeroRecord { get; set; }

        [FieldFixedLength(25)]
        public string Filler4 { get; set; }

        [FieldFixedLength(6)]
        public string CampoNonDisponibile { get; set; }
    }
}
