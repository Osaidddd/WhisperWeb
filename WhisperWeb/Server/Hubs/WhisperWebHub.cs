using WhisperWeb.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace WhisperWeb.Server.Hubs
{
    [Authorize]
    public class WhisperWebHub : Hub<IWhisperWebHubClient>, IWhisperWebHubServer
    {
        private static readonly IDictionary<int, UserDto> _onlineUsers = new Dictionary<int, UserDto>();
        
        public WhisperWebHub()
        {

        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public async Task SetUserOnline(UserDto user)
        {
            await Clients.Caller.OnlineUsersList(_onlineUsers.Values);
            if (!_onlineUsers.ContainsKey(user.Id))
            {
                _onlineUsers.Add(user.Id, user);
                await Clients.Others.UserIsOnline(user.Id);
            }
        }
    }
}