using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcomTask.Models
{
    public class ProductReviewVM
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? PName { get; set; }
        [Required]
        [StringLength(250)]
        public string? Description { get; set; }
        [Required]

        [Range(0, 10000)]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
       

    }
}
