using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_C2110I_22_6_CURD_relationship.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please input product name!")]
        public string Name { get; set; }
        public double Price { get; set; }
        [ForeignKey(nameof(Category.Id))]
        public int CategoryId { get; set; }
        public virtual Category category { get; }

    }
}
