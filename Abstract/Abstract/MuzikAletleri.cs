using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class MuzikAletleri
    {
        public abstract string Cal();
        public string Mensei { get; set; }
        public DateTime UretimTarihi { get; set; }
        public abstract CalmaTuru CalmaTuru  { get; set; }


    }
}
