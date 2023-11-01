using Microsoft.AspNetCore.Mvc;
using MovieContext.Model.Movie;
using MovieData.Interfaces;
using System.Linq;
using Travel.Shared.ViewModels;

namespace MovieAnime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private Response res;
        private IAuthentication authentication;
        public AuthenticationController(IAuthentication _authentication)
        {
            authentication = _authentication;
            res = new Response();
        }

        [HttpPost("Login")]
        public object Login(User model)
        {
            res = authentication.Login(model);
            return Ok(res);
        }
    }
}
