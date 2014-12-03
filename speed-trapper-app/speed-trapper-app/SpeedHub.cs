using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using speed_trapper_app.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace speed_trapper_app
{
    [HubName("speedHub")]
    public class SpeedHub: Hub
    {
        static string connId;
        public void sendCarDetails(string name, int speed)
        {
            int flag = 0;
            if (speed > SpeedController.speedLimit)
            {
                Clients.Caller.showBustedMessage();
                flag = 1;
            }
            var Context = GlobalHost.ConnectionManager.GetHubContext<SpeedHub>();
            Context.Clients.Client(connId).showCarOnSpeedTracker(name, speed, flag);
        }
        public void initialize()
        {
            connId = Context.ConnectionId;
        }

    }
}