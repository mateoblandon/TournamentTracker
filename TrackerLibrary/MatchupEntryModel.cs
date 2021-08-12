namespace TrackerLibrary
{
  public class MatchupEntryModel
  {
    /// <summary>
    /// Representa un equipo en un encuentro
    /// </summary>
    public TeamModel TeamCompeting { get; set; }

    //Representa el puntaje
    public double Score { get; set; }

    //Representa el encuentro de donde vino el presente equipo como ganador
    public MatchupModel ParentMatchup { get; set; }
  }
}