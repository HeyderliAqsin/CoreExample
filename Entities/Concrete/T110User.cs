using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class T110User:IdentityUser
    {
        [MaxLength(50)]
        public string Firstname { get; set; }=null!;
        [MaxLength(50)]
        public string Lastname { get; set; } = null!;
        public string? Address { get; set; }
    }
}
