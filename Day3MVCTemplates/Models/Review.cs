using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace Day3MVCTemplates.Models
{
    public class Review
    {
        public int Id { get; set; }

        [DisplayName("What is your name?")]
        public string ReviewerName { get; set; }

        [DisplayName("How was your experience?")]
        public string Body { get; set; }
        public int Rating { get; set; }
        public DateTime Created { get; set; }
    }

    public class ReviewContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}