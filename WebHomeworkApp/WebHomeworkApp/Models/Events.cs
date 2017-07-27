using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHomeworkApp.Models
{
    public class Events
    {
        // GET: Events
        public int Id { get; set; }

        public string Title { get; set; }
        //[Required]
        public string Details { get; set; }

        public string Location { get; set; }

        public DateTime DateAndTime { get; set; }

        public string Image { get; set; }
    }
}