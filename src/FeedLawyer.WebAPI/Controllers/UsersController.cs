using FeedLawyer.Application.Contracts;
using FeedLawyer.Application.Contracts.Documents.Links;
using FeedLawyer.Application.Contracts.Documents.User;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FeedLawyer.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(
            //DataContext context, 
            IUserService userService)
        {
            //_context = context;
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Create([FromBody] CreateUserDTO createUser)
        {
            UserDTO newUser = await _userService.CreateUserAsync(createUser);
            return CreatedAtAction(nameof(Details), new { newUser.Id }, newUser);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
                return NotFound();

            var response = new UserDTO(
                user.Id,
                user.UserName,
                user.Email,
                user.Roles
            )
            {
                Links = new List<LinkDTO>
                {
                    new LinkDTO
                    {
                        Href = Url.Action(nameof(Details), "Users", new { id = user.Id })!,
                        Rel = "self",
                        Method = "GET"
                    },
                    new LinkDTO
                    {
                        Href = Url.Action(nameof(Update), "Users", new { id = user.Id })!,
                        Rel = "update_user",
                        Method = "PUT"
                    }
                    //new LinkDTO
                    //{
                    //    Href = Url.Action(nameof(Delete), "Users", new { id = user.Id })!,
                    //    Rel = "delete_user",
                    //    Method = "DELETE"
                    //}
                }
            };

            return Ok(response);
        }
    }
}
