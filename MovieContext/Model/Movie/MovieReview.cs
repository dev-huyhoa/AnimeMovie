using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class MovieReview
    {
        public Guid IdReview { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content { get;set; }
        public bool IsDelete { get; set; }
        public Guid IdCustomer { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
