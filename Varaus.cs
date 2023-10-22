using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class Varaus
    {

        public int varaus_id { get; set; }
        public int asiakas_id { get; set; }
        public int mokki_mokki_id { get; set; }
        public DateTime varattu_pvm { get; set; } //Nämä on nyt stringeinä, kun en muuten saanut toimimaan koodia. 
        public DateTime vahvistus_pvm { get; set; }
        public DateTime varattu_alkupvm { get; set; }
        public DateTime varattu_loppupvm { get; set; }

    }
}
