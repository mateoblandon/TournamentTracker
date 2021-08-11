using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; } // Winner va a invocar a la clase TeamModel y las propiedades que contiene.
        public int MatchupRound { get; set; }
    }
}
