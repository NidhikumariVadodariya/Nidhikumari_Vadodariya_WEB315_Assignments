using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace NidhiVadodariyaChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageToOthers(string user, string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
           
        }
        public async Task Send(string user, string message)
        {
            await Clients.Caller.SendAsync("ReceiveMessage", user, message);
           
        }
    }
}