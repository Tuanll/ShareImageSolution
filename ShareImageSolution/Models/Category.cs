using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareImageSolution.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public string Suggesstion { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
