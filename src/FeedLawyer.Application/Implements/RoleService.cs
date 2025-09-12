using FeedLawyer.Application.Contracts;
using FeedLawyer.Domain.Contracts.Repositories;
using FeedLawyer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Implements
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<Role?> GetRoleById(Guid id)
        {
            return await _roleRepository.GetRoleById(id);
        }

        public async Task<List<Role?>> GetRolesByNamesAsync(IEnumerable<string> names)
        {
            return await _roleRepository.GetRolesByNamesAsync(names);
        }
    }
}
