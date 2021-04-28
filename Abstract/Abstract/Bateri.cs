using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Bateri:MuzikAletleri
    {
        public override CalmaTuru CalmaTuru
        {
            get
            {
                return CalmaTuru.SallamaliCalma;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Cal()
        {
            return "Bateri caliniyor";
        }
    }
}
