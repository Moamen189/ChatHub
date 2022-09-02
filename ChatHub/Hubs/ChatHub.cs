using ChatHub.Contexts;
using ChatHub.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace ChatHub.Hubs
{
    public class ChatHubs:Hub
    {
        public async Task Send(string user, string message)
        {
           await Clients.All.SendAsync("ReceiveMessage",user, message ); //Fire Event

            ChatContext Context = new ChatContext();
            Message messageObj = new Message() { message_text = message, user_name = user, message_date = message  };
            Context.Messages.Add(messageObj);
            Context.SaveChanges();
        }
    }
}
