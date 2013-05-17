using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresenterWatchWeb.Hubs
{
    public class SpeakerWatchHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.addMessage(message);
        }

        public void Start(int duration)
        {
            Clients.All.start(duration);
        }

        public void Stop()
        {
            Clients.All.stop();
        }

        public void Add5()
        {
            Clients.All.add5();
        }

        public void Add10()
        {
            Clients.All.add10();
        }

        public void GetAttention()
        {
            Clients.All.getAttention();
        }

        public void Comment()
        {
            Clients.All.getAttention();
        }
    }
}