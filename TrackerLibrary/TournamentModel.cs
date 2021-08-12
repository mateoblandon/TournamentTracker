using System.Collections.Generic;

namespace TrackerLibrary
{
  public class TournamentModel
  {
    //La palabra Model en este contexto hace referencia a Clase.
    public string TournamentName { get; set; }

    public decimal EntryFee { get; set; }
    public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
    public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
    public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
  }
}