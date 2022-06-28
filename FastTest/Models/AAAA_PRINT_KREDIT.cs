using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastTest.Models
{
    public class AAAA_PRINT_KREDIT
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PRINT_ID { get; set; } // int, null
        public double PRINT_AVTOMOBILIN_DEYERI { get; set; } // float, null
        public string  PRINT_KREDIT_MUDDETI { get; set; } // nvarchar(50), null
        public string  PRINT_GUZEST_MUDDETI { get; set; } // nvarchar(50), null
        public string  PRINT_ILLIK_FAIZ { get; set; } // nvarchar(50), null
        public double PRINT_KREDITIN_MEBLEGI { get; set; } // float, null
        public double PRINT_AYLIQ_ODEME { get; set; } // float, null
        public double PRINT_ILKIN_ODENIS { get; set; } // float, null
        public double PRINT_SIGORTA { get; set; } // float, null
        public double PRINT_BANK_XIDMETI { get; set; } // float, null
        public double PRINT_DYP_QEYDIYATI { get; set; } // float, null
        public int PRINT_SIRA { get; set; } // int, null
        public DateTime PRINT_ODEME_TARIXI { get; set; } // date, null
        public double PRINT_KREDITTEN_ODEMELER { get; set; } // float, null
        public double PRINT_KREDIT_QALIQLARI { get; set; } // float, null
        public double PRINT_FAIZLERDEN_ODEMELER { get; set; } // float, null
        public double PRINT_ODENMELI_MEBLEG { get; set; } // float, null
        public double PRINT_BAZI_TOPLAMLAR { get; set; } // float, null
        public string  PRINT_MUSTERI_ADI_FAMILYASI { get; set; } // nvarchar(50), null
    }

}
