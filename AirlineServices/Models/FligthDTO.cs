using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airline_NewshoreFly.Models
{
    public class FligthDTO
    {
        public long Id { get; set; }

        public string DepartureStation { get; set; }

        public string ArrivalStation { get; set; }

        public System.DateTime DepartureDate { get; set; }

        public decimal Price { get; set; }

        public string Transport { get; set; }

        public string Currency { get; set; }

        public string FligthTime { get; set; }
    }
}