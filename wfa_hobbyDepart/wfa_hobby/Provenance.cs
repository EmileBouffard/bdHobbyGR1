using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class Provenance
    {
        private int no_provenance;
        private string provenanceDescription;

        public int No_provenance { get => no_provenance; set => no_provenance = value; }
        public string ProvenanceDescription { get => provenanceDescription; set => provenanceDescription = value; }
    }
}
