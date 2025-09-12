using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Domain.Exceptions
{
    public class EmailAlreadyExistsException : ApplicationException
    {
        public EmailAlreadyExistsException(string email)
        : base($"O e-mail '{email}' já está cadastrado.")
        {
        }
    }
}
