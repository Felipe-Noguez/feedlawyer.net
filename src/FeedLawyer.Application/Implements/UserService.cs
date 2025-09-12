using FeedLawyer.Application.Contracts;
using FeedLawyer.Application.Contracts.Documents.Role;
using FeedLawyer.Application.Contracts.Documents.User;
using FeedLawyer.Domain.Contracts.Abstractions;
using FeedLawyer.Domain.Contracts.Repositories;
using FeedLawyer.Domain.Exceptions;
using FeedLawyer.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Implements
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleService _roleService;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IRoleService roleService, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _roleService = roleService;
            _unitOfWork = unitOfWork;
        }

        public async Task<UserDTO> CreateUserAsync(CreateUserDTO createUser)
        {
            if (await _userRepository.GetUser(createUser.Email) != null)
                throw new EmailAlreadyExistsException(createUser.Email);

            var roleNames = createUser.Roles.Select(r => r.Name).ToList();

            var roles = await _roleService.GetRolesByNamesAsync(roleNames);

            if (roles.Count != roleNames.Count)
            {
                var notFound = roleNames.Except(roles.Select(r => r.Name)).ToList();
                throw new RoleNotFoundException(string.Join(", ", notFound));
            }
            User newUser = new(createUser.UserName, createUser.Email, createUser.Password, roles);

            await _userRepository.AddAsync(newUser);
            await _unitOfWork.CommitAsync();

            return new UserDTO(newUser.Id, newUser.UserName, newUser.Email, newUser.Roles.Select(r => new RoleDTO(r.Id, r.Name)).ToList());
        }

        public async Task<UserDTO> GetUserById(Guid id)
        {
            User userDB = await _userRepository.GetUserById(id);

            if (userDB == null)
                throw new UserNotFoundException(id.ToString());



            return new UserDTO(userDB.Id, userDB.UserName, userDB.Email, userDB.Roles.Select(r => new RoleDTO(r.Id, r.Name)).ToList());
        }
    }
}
