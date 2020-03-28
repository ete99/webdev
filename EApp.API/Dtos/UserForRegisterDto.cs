using System;
using System.ComponentModel.DataAnnotations;

namespace EApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required] // validation
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must provide a password between 4 and 8 characters")]
        public string Password { get; set; }
        [Required]
        public string Gender {get; set; }
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}