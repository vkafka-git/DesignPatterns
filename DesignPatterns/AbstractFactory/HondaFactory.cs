﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class.
    /// </summary>
    class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
            }

        }

        public IScooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
            }

        }
    }
}
