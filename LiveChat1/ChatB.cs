using Microsoft.AspNetCore.SignalR;

namespace LiveChat1
{
    public class ChatB :Hub
    {
        public async Task SendMessage(string room, string user, string message)
        {
            await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
        }

        public async Task AddToGroup(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("ShowPerson",
                $"Alguien se conecto{Context.ConnectionId}");
        }
    }
}
