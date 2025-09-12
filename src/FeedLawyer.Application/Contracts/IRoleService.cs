using FeedLawyer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Contracts
{
    public interface IRoleService
    {
        Task<Role?> GetRoleById(Guid id);
        Task<List<Role?>> GetRolesByNamesAsync(IEnumerable<string> names);
    }
}
