using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C2110I_API_buoi1_15_6.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name must be not null!")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Category name only contains alphabet")]
        public string? Name { get; set; }
    }
}
