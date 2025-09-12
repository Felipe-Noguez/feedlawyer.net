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
    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext _context;

        public RoleRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Role?> GetRoleById(Guid id)
        {
            return await Task.FromResult(_context.Roles.FirstOrDefault(r => r.Id == id));
        }

        public async Task<List<Role>> GetRolesByNamesAsync(IEnumerable<string> names)
        {
            return await _context.Roles
                .Where(role => names.Contains(role.Name))
                .ToListAsync();
        }
    }
}
