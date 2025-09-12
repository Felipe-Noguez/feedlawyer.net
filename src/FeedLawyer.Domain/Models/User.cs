using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Domain.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string userName, string password, string email, List<Role> roles)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Roles = roles;
        }

        public User(Guid id, string userName, string password, string email, List<Role> roles)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Email = email;
            Roles = roles;
        }

        public Guid Id { get; private set; }
        public string UserName { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;
        public string Email { get; private set; }
        public Guid RoleId { get; private set; }
        public List<Role> Roles { get; private set; } = new List<Role>();
    }
}
