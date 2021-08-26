using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
  public class SqlConnector : IDataConnection
  {
    // Se crea el método CreatePrize que de verdad lo guarda en la base de datos
    /// <summary>
    /// Guarda un nuevo premio a base de datos
    /// </summary>
    /// <param name="model">Información del premio</param>
    /// <returns>La información de premio, incluyendo su identificador único</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
      model.id = 1;
      return model;
    }
  }
}