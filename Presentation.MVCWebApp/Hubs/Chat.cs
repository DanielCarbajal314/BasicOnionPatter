using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Presentation.MVCWebApp.Hubs
{
    public class Chat : Hub
    {
        public void PushMessage(UserMessage userMessage)
        {
            Clients.Others.NewMessage(userMessage);
        }

        public void suscribe()
        {
            
        }
    }

    public class UserMessage {
        public string UserName { get; set; }
        public string Message { get; set; }
    }
}