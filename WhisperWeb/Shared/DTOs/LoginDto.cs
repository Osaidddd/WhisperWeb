using System.ComponentModel.DataAnnotations;

namespace WhisperWeb.Shared.DTOs
{
    public class LoginDto
    {
        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(25), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
