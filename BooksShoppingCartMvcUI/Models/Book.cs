﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace BooksShoppingCartMvcUI.Models
{
    [Table("Book")]
    public class Book
    {        
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }
        [Required]
        public double Price { get; set; }
        public string Image { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre {  get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }

    }
}
