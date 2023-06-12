using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UsersAPI.Models
{
    public class User : IdentityUser
    {
        public DateTime BornDate { get; set; }

        public User() : base() {  }
    }
}
