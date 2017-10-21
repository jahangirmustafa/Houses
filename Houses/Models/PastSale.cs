using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Houses.Models
{
    public class PastSale
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Info { get; set; }        
        public string ImagePath { get; set; }        
        public DateTime SoldDate { get; set; }
        public string Represented { get; set; }
       
    }
}
