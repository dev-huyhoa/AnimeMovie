using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class MovieEpisode
    {
        public string IdEpisode { get; set; }
        public int PartNumber { get; set; }
        public string NameEpisode { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
