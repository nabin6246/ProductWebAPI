
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductPrice { get; set; }
    }
}
