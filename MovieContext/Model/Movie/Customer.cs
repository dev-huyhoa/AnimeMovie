using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class Customer
    {
        public Guid IdCustomer { get; set; }
        public string NameCustomer { get; set; }
        public DateTime CreateDate { get; set; }   
        public bool IsDelete {  get; set; }
    }
}
