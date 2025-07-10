using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }
    }
}


