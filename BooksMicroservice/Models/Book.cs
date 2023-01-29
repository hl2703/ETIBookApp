using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace BrowseBook.Models
{
    public class Book
    {
        [Display(Name = "ISBN")]
        public int Isbn { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Category")]
        public string Category { get; set; }
        [Display(Name = "Author")]
        public string Author { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "IsAvail")]
        public string IsAvail { get; set; }
        public string Photo { get; set; }
    }
}
