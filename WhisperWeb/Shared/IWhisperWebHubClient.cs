using WhisperWeb.Shared.DTOs;

namespace WhisperWeb.Shared
{
    public interface IWhisperWebHubClient
    {
        Task UserConnected(UserDto user);
        Task OnlineUsersList(IEnumerable<UserDto> users);
        Task UserIsOnline(int userId);

        Task MessageRecieved(MessageDto messageDto);
    }
}