using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        //Seccción que contienes propiedades. La palabra Model en este contexto hace referencia a Clase.
        #region Propiedades
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
        #endregion
    }
}
