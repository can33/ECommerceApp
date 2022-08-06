using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        
        [ForeignKey("BrandId")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
