﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BookListMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

    }
}


