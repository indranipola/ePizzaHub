using ePizzaHub.Core.Contracts;
using ePizzaHub.Models.ApiModels.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePizzaHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly Iuserservice _userService;

        public UserController(Iuserservice userService)
        {
            this._userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest userRequest)
        {
            //Validation
            //Call BAL
            //Call DAL
            var result=await _userService.CreateUserRequestAsync(userRequest);

            return Ok(result);

        }

    }
}

