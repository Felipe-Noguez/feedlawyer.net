using FeedLawyer.Application.Contracts.Documents.Links;
using FeedLawyer.Application.Contracts.Documents.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Contracts.Documents.User
{
    [DataContract]
    public record UserDTO
    {
        public UserDTO(Guid id, string userName, string email, List<RoleDTO> roles)
        {
            Id = id;
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Roles = roles ?? throw new ArgumentNullException(nameof(roles));
        }

        [DataMember(Order = 1)]
        public Guid Id { get; set; }
        [DataMember(Order = 2)]
        public string UserName { get; private set; } = string.Empty;
        [DataMember(Order = 3)]
        public string Email { get; private set; }
        [DataMember(Order = 4)]
        public List<RoleDTO> Roles { get; private set; }
        [DataMember(Order = 5)]
        public List<LinkDTO> Links { get; set; } = new();
    }
}
