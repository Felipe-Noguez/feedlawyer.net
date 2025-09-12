using FeedLawyer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Domain.Contracts.Repositories
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetRolesByNamesAsync(IEnumerable<string> names);
        Task<Role?> GetRoleById(Guid id);
    }
}
