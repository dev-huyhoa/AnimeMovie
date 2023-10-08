using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class MoviePart
    {
        public Guid IdPart { get; set; }
        public string NamePart { get; set; }
        public string DescriptionPart { get; set; }
        public int PartNumber { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
