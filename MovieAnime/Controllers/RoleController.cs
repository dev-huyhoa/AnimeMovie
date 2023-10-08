using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieContext.Model.Movie;
using MovieData.Interfaces;
using Travel.Shared.ViewModels;

namespace MovieAnime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private IRole role;
        private Response res;

        public RoleController(IRole _role)
        {
            role = _role;
            res = new Response();
        }

        [HttpGet]
        [Route("list-role")]
        public object GetsRole()
        {
            res = role.GetsRole();
            return Ok(res);
        }
    }
}
