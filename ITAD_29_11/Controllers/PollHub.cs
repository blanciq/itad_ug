using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;

namespace ITAD_29_11.Controllers
{
    public class PollHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}