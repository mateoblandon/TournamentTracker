using System.Collections.Generic;

namespace TrackerLibrary
{
  public class MatchupModel
  {
    public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
    public TeamModel Winner { get; set; } // Winner va a invocar a la clase TeamModel y las propiedades que contiene.
    public int MatchupRound { get; set; }
  }
}