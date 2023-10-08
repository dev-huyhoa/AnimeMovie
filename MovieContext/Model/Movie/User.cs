using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class User
    {
        public Guid IdUser { get; set; }
        public string NameUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Birthday { get; set; }
        public int Gender { get; set; }
        public string UrlImage { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public bool IsDelete { get; set; }
    }
}
