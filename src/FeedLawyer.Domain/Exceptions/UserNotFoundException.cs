using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Domain.Exceptions
{
    public class UserNotFoundException : ApplicationException
    {
        public UserNotFoundException(string user)
        : base($"Usuário '{user}' não cadastrado.")
        {
        }
    }
}
