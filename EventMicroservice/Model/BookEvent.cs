using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventMicroservice.Models
{
    public class BookEvent
    {
        [Display(Name = "ID")]
        public int EventID { get; set; }
        [Display(Name = "Name")]
        public string EventName{ get; set; }
        [Display(Name = "Start Date")]
        public DateTime StartDate{ get; set; }
        [Display(Name = "End Date")]
        public DateTime  EndDate { get; set; }
        [Display(Name = "Description")]
        public string EventDescription { get; set; }
       
     
    }
}
