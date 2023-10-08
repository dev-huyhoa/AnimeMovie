using Microsoft.EntityFrameworkCore;
using MovieContext.Model.Movie;
using MovieData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Shared.ViewModels;

namespace MovieData.Repositories
{
    public class RoleRes : IRole
    {
        private readonly MovieAnimeContext _db;
        private Response res;
        public RoleRes(MovieAnimeContext db)
        {
            _db = db;
            res = new Response();
        }
        public Response GetsRole()
        {
            try
            {
                var listRole = (from x in _db.Roles.AsNoTracking()
                                select x).ToList();
                res.Data = listRole;
                res.Success = true;
                return res;
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Description = ex.Message;
                return res;
            }
        }
    }
}
