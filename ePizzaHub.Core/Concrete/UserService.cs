using ePizzaHub.Core.Contracts;
using ePizzaHub.Models.ApiModels.Request;
using ePizzaHub.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Core.Concrete
{
    public class UserService: Iuserservice
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;
        public UserService(IRoleRepository roleRepository,IUserRepository userRepository) 
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
        }
        public Task<bool> CreateUserRequestAsync(CreateUserRequest createUserRequest)
        {
            //1.Insert records user table and user role Table
            //2. Hash password sending my end user
            var rolesDetails = _roleRepository.GetAll().Where(x => x.Name == "User").FirstOrDefault();
            if (rolesDetails != null)
            { 
                //
            }

            throw new NotImplementedException();
        }
    }
}
