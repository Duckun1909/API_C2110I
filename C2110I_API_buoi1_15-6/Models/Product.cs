using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C2110I_API_buoi1_15_6.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public double Price { get; set; }
        [ForeignKey(nameof(Category.Id))]
        public int CategoryId { get; set; }
        public virtual Category category { get; }
    }
}
