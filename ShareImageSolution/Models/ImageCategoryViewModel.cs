using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareImageSolution.Models
{
    public class ImageCategoryViewModel
    {
        public int ImageId { get; set; }
        public string Alt { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public string Suggesstion { get; set; }
    }
}
