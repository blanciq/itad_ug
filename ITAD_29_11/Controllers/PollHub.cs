using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;

namespace ITAD_29_11.Controllers
{
    public class PollHub : Hub
    {
        public void Vote(string answer)
        {
            PollController.Votes
                .SingleOrDefault(x => x.Answer == answer).Count++;

            Clients.All.UpdateVotes(PollController.Votes);
        }
    }
}