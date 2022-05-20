using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class RegisterDTO
    {
        [MaxLength(50)]
        public string Firstname { get; set; } = null!;
        [MaxLength(50)]
        public string Lastname { get; set; }= null!;
        [EmailAddress]
        public string Email { get; set; }= null!;

        [DataType(DataType.Password)]
        public string Password { get; set; }= null!;
        [DataType(DataType.Password)]

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }= null!;
    }
}
