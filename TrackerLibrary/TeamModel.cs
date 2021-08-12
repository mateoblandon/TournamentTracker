using System.Collections.Generic;

namespace TrackerLibrary
{
  public class TeamModel
  {
    //Seccción que contienes propiedades. La palabra Model en este contexto hace referencia a Clase.

    #region Propiedades

    public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    public string TeamName { get; set; }

    #endregion Propiedades
  }
}