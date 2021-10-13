using Airline_NewshoreFly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "FligthService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione FligthService.svc o FligthService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class FligthService : IFligthService
    {
        AirlineEntities data = new AirlineEntities();
        public void DoWork()
        {
            throw new NotImplementedException();
        }

        List<Flight> IFligthService.Find(string origen, string destino, DateTime fechaLlegada)
        {
            var listFlights = (from m in data.Flight
                               where m.DepartureStation == origen && m.ArrivalStation == destino && m.DepartureDate == fechaLlegada
                               select m).ToList();

            return listFlights;
        }
    }
}
