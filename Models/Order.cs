using System;
using System.ComponentModel.DataAnnotations;

namespace RecordStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        public User Buyer { get; set; }

        [Required]
        public int RecordId { get; set; }

        public Record Record { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int QuantityBought { get; set; }

        [Required]
        public double OrderTotal { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}