using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    // Strategy Interface
    // The ITravelStrategy Interface declares the method GotoAirport that is common to all supported versions of the algorithm.
    // The Context is going to use this Strategy Interface to call the algorithm defined by Concrete Strategies.
    public interface ITravelStrategy
    {
        void GotoAirport();
    }

    public enum TravelType
    {
        Auto = 1,  // 1 for Auto
        Bus = 2,   // 2 for Bus
        Train = 3, // 3 for Train
        Taxi = 4  // 4 for Taxi
    }
}
