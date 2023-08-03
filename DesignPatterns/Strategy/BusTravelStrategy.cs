using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    // Concrete Strategy D
    // The following BusTravelStrategy Concrete Strategy implement the ITravelStrategy Interface and 
    // Implement the GotoAirport Method. 
    public class BusTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by bus and will be charged Rs 300");
        }
    }
}
