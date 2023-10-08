using WhisperWeb.Shared.DTOs;

namespace WhisperWeb.Shared
{
    public interface IWhisperWebHubServer
    {
        Task SetUserOnline(UserDto user);
    }
}