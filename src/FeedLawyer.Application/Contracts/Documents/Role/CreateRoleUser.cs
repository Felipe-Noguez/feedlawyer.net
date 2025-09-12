using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Contracts.Documents.Role
{
    public record CreateRoleUser
    {
        public CreateRoleUser(string name)
        {
            Name = name;
        }

        public string Name { get; private set; } = string.Empty;
    }
}
