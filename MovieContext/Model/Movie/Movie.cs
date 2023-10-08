using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class Movie
    {
        public Guid IdMovie { get; set; }
        public string NameMovie { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime RealesDate { get; set; }
        public string Description { get; set; }
        public int ViewNumber { get; set; }
        public int Rating { get; set; }
        public bool IsDelete { get; set; }
        public bool Status { get; set; }
        public ICollection<MovieEpisode> MovieEpisode { get; set; }
        public ICollection<MovieGenreLink> MovieGenreLinks { get; set; }
        public ICollection<MoviePart> MovieParts { get; set; }
        public ICollection<MovieReview> MovieReviews { get; set; }


    }
}
