using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShoppingCart.Models
{
    public class Page
    {
        public int Id { set; get; }
        [Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
        public string Title { set; get; }
        public string Slug { set; get; }
        [Required, MinLength(4, ErrorMessage = "Minimum length is 4")]
        public string Content { set; get; }
        public int Sorting { set; get; }
    }
}
