using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShare.ViewModels
{
    public class RoleViewModel
    {
        public int IdRole { get; set; }
        public string NameRole { get; set; }
        public string Description { get; set; }
        public bool IsSave { get; set; }
    }
}
