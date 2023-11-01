using Microsoft.EntityFrameworkCore;
using MovieContext.Model.Movie;
using MovieData.Interfaces;
using MovieShare.ViewModels;
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
        private readonly IRepositoryAsync<Role> _roleRepository;
        private readonly MovieAnimeContext _db;
        private Response res;
        public RoleRes(MovieAnimeContext db, IRepositoryAsync<Role> roleRepository)
        {
            _db = db;
            res = new Response();
            _roleRepository = roleRepository;
        }
        public async Task<Response> GetsRole()
        {
            var result = await _roleRepository.Entities(e => e.IdRole == 1);
            res.Data = result;
            res.Success = true;
            return res;
        }

        public async Task<Response> SaveRole(RoleViewModel input)
        {
            try
            {
                Role role = new Role();
                if (input.IsSave)
                {
                    role.NameRole = input.NameRole;
                    role.Description = input.Description;
                    await _roleRepository.AddAsync(role);
                }
                else
                {
                    var roles = (from x in _db.Roles
                            where role.IdRole == input.IdRole
                            select x).FirstOrDefault();

                    role.NameRole = input.NameRole;
                    role.Description = input.Description;
                    _db.Roles.Update(role);
                }
                return res;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Response SaveRole()
        {
            throw new NotImplementedException();
        }
    }
}
