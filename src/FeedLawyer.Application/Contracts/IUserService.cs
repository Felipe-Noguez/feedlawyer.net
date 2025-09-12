using FeedLawyer.Application.Contracts.Documents.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Contracts
{
    public interface IUserService
    {
        Task<UserDTO> CreateUserAsync(CreateUserDTO createUser);
        Task<UserDTO> GetUserById(Guid id);
    }
}
