using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareImageSolution.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Alt { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public int View { get; set; }
        public int DownLoad { get; set; }
        public DateTime DateCreated { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
