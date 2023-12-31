﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Bilgisayar
    {
        public int Id { get; set;}
        public string Marka { get; set;}
        public string Model { get; set;}
        public BilgisayarTipi Tipi { get; set; }
        public double GHz { get; set; }
        public short Hafiza { get; set; }
        public double EkranBoyutu { get; set; }
        public bool SogutmaliMi { get; set; }
        public DateTime UretimTarihi { get; set; }
    }
}
