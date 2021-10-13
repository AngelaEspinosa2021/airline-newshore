using Airline_NewshoreFly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IFligthService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IFligthService
    {
        [OperationContract]
        List<FligthDTO> FindFligths(string origen, string destino, DateTime fechaLlegada);
    }
}
