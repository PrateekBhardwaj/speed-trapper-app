using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Assignment_Exzeo.Hubs
{
    public class Hubs : Hub
    {
        public void Send(string name, int speed)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, speed);
        }
    }
}
