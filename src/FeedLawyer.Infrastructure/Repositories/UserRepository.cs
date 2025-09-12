using FeedLawyer.Domain.Contracts.Repositories;
using FeedLawyer.Domain.Models;
using FeedLawyer.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        => await _context.Users.AddAsync(user);

        public User? GetUser(string username, string password)
        {
            return _context.Users.FirstOrDefault(user => user.UserName == username && user.Password == password);
        }

        public async Task<User?> GetUser(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> GetUserById(Guid id)
        {
            return await _context.Users
                .Include(u => u.Roles)
                .FirstOrDefaultAsync(u => u.Id.Equals(id));
        }
    }
}
