using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class Laskutus
    {
        public int lasku_id { get; set; }
        public int varaus_id { get; set; }
        public double summa { get; set; }
        public double alv { get; set; }
        public int tila { get; set; }
        public DateTime erapva { get; set; }


    }
}
