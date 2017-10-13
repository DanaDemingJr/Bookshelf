﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Genre { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}