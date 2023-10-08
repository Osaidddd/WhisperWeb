using System.ComponentModel.DataAnnotations;

namespace WhisperWeb.Shared.DTOs
{
    public class RegisterDto
    {
        [Required, MaxLength(25)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(25), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
