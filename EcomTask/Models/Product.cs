using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace EcomTask.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(250)]
        public string? Description { get; set; }
        [Required]

        [Range(0, 10000)]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }

        //public ICollection<Review> Reviews { get; set; }

    }
}
