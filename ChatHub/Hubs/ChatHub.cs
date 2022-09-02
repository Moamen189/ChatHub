using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatHub.Hubs
{
    public class ChatHubs:Hub
    {
        public async Task Send(string user, string message)
        {
           await Clients.All.SendAsync("ReceiveMessage",user, message); //Fire Event
        }
    }
}
