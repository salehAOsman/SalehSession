using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DisplayLIstBySession.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "your name")]
        public string Name { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "your phone")]
        public string Phone { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = " your city")]
        public string City { get; set; }
        //[DataType(DataType.Date)]
        //public DateTime PublishDate { get; set; }
    }
}