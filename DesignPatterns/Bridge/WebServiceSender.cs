﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Service\n{0}\n{1}\n", subject, body);
        }
    }
}
