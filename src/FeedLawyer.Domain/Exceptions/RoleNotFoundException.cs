using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Domain.Exceptions
{
    public class RoleNotFoundException : ApplicationException
    {
        public RoleNotFoundException(string role)
        : base($"Role '{role}' não cadastrado.")
        {
        }
    }
}
