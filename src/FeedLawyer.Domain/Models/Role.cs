using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Domain.Models
{
    public class Role
    {
        public Role()
        {
        }

        public Role(Guid id, string name, List<User> users)
        {
            Id = id;
            Name = name;
            Users = users;
        }
        public Role(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public List<User> Users { get; private set; } = new List<User>();
    }
}
