using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class Laskutettavat
    {
        public int varaus_id { get; set; }
        public string etunimi { get; set; }
        public string sukunimi { get; set; }
        public string email { get; set; }
        public string mokkinimi { get; set; }
        public double hintaperyo { get; set; }
        public int reissuaika { get; set; }
        public int palvelu_id { get; set; }
        public string palvelunimi { get; set; }
        public double palvhinta { get; set; }
        public int palvmaara { get; set; }
        public double kokhinta { get; set; }

        public DateTime loppupvm { get; set; }



    }
}
