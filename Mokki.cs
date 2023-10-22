﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class Mokki
    {
        public int mokki_id { get; set; }
        public int alue_id { get; set; }
        public string postinro { get; set; }
        public string mokkinimi { get; set; }
        public string katuosoite { get; set; }
        public double hinta { get; set; }
        public string kuvaus { get; set; }
        public int henkilomaara { get; set; }
        public string varustelu { get; set; }

        public List<Varaus> varaukset { get; set; }
    }
}
