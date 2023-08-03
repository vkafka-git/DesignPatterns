using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    // The Context Provides the interface which is going to be used by the Client.
    public class TravelContext
    {
        // The Context has a reference to one of the Strategy objects.
        // The Context does not know the concrete class of a strategy. 
        // It should work with all strategies via the Strategy interface.
        private ITravelStrategy travelStrategy;
        // The Client will set what TravelStrategy to use by calling this method at runtime
        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            travelStrategy = strategy;
        }
        // The Context delegates the work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void GotoAirport()
        {
            travelStrategy.GotoAirport();
        }
    }
}
