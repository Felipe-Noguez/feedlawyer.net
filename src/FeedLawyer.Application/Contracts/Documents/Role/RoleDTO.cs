using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Contracts.Documents.Role
{
    [DataContract]
    public record RoleDTO
    {
        public RoleDTO(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        [DataMember(Order = 1)]
        public Guid Id { get; private set; }
        [DataMember(Order = 2)]
        public string Name { get; private set; } = string.Empty;
    }
}
