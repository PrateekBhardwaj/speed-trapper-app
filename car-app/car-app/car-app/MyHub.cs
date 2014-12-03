using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace car_app
{
    [HubName("myhub")]
    public class MyHub: Hub
    {
        public void Send(string name, int speed)
        {
            // Call the broadcastMessage method to update clients.
            Clients.Caller.clientmethod(name, speed);
        }
    }
}