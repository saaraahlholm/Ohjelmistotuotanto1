﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class Asiakas
    {
        public int asiakas_id { get; set; }
        public string postinro { get; set; }
        public string etunimi { get; set; }
        public string sukunimi { get; set; }
        public string lahiosoite { get; set; }
        public string email { get; set; }
        public string puhelinnro { get; set; }
        public List<Varaus> varaukset { get; set; }
    }
}
