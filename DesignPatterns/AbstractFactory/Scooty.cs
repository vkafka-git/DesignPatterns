using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Scooty : IScooter
    {
        public string Name()
        {
            return "Scooty- Name";
        }
    }
}
