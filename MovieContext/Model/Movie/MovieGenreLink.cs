using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class MovieGenreLink
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid CategoryId { get; set; }
        public Movie Movie { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
