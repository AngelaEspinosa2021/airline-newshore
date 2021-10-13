using Airline_NewshoreFly.Models;
using AirlineServices.Models;
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
        AirlineEntities1 data = new AirlineEntities1();

        List<FligthDTO> IFligthService.FindFligths(string origen, string destino, DateTime fechaLlegada)
        {
            var listFlights = (from m in data.Flight
                               where m.DepartureStation == origen && m.ArrivalStation == destino && m.DepartureDate == fechaLlegada
                               select new FligthDTO
                               {
                                   Id = m.Id,
                                   DepartureStation = m.DepartureStation,
                                   ArrivalStation = m.ArrivalStation,
                                   DepartureDate = (DateTime)m.DepartureDate,
                                   Transport = m.Transport,
                                   Price = (decimal)m.Price,
                                   Currency = m.Currency,
                                   FligthTime = m.FlightTime
                               });

            return listFlights.ToList();
        }
    }
}
