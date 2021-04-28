using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Gitar:MuzikAletleri
    {
        public override CalmaTuru CalmaTuru
        {
            get
            {
                return CalmaTuru.TelliCalma;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public override string Cal()
        {
            return "Gitar caliniyor";
        }
    }
}
