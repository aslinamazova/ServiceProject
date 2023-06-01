using Service.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class Restaurant:BaseAuditibleEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public List<Product> ?Products { get; set; }
    }
}
