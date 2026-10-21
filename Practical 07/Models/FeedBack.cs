using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FeedBackManagmentSystem.Models
{
    public class FeedBack
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string EnrollMentNo { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Comments { get; set; }
    }
}