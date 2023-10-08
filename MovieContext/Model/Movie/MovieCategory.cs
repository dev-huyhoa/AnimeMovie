using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class MovieCategory
    {
        public Guid IdCategory { get; set; }
        public string NameCategory { get; set; }
        public string Description {  get; set; }
        public string CreateDate { get; set; }
        public ICollection<MovieGenreLink> MovieGenreLinks { get; set; }

    }
}
