using FeedLawyer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Domain.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        User? GetUser(string username, string password);
        Task<User?> GetUser(string email);
        Task<User?> GetUserById(Guid id);
    }
}
