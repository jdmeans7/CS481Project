using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS481WebApp.Models
{
    public class Blog
    {
        public int ID { get; set; }
        //Foreign key for User
        public int AuthorID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }


}