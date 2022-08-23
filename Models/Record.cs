using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecordStore.Models
{
    public class Record
    {
        [Key]
        public int RecordId { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter an artist.")]
        public string Artist { get; set; }

        [Required(ErrorMessage = "Please enter a cover link.")]
        public string Cover { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [Range(0.01, int.MaxValue, ErrorMessage = "Price must be greater than 0.00.")]
        public double Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please enter a Spotify embed link.")]
        public string Spotify { get; set; }

        public int UserId { get; set; }
        public User Seller { get; set; }

        public List<Order> Orders { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}