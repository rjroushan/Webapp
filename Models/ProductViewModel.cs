using System.ComponentModel;

namespace Webapp.Models
{
    public class ProductViewModel
    {
        [DisplayName("Product Id")]
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Product Code")]
        public string ProductCode { get; set; }
        [DisplayName("Price")]
        public decimal Price { get; set; }
    }
}
