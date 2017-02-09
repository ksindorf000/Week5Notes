using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day4MVCUser.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }

        public string OwnerId { get; set; } //Guid

        [ForeignKey("OwnerId")]
        public virtual ApplicationUser Owner { get; set; } 

    }
}