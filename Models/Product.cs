﻿using Service.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Product : BaseAuditibleEntity
    {
        [Required]
        [MaxLength(70)]
        public string Name { get; set; }
        public double Price { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
