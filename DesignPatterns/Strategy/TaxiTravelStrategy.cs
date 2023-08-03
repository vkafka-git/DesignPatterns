using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    // Concrete Strategy C
    // The following TaxiTravelStrategy Concrete Strategy implement the ITravelStrategy Interface and 
    // Implement the GotoAirport Method. 
    public class TaxiTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Taxi and will be charged Rs 1000");
        }
    }
}
