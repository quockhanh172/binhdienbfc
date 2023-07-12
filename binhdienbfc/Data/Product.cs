using System.ComponentModel.DataAnnotations.Schema;

namespace binhdienbfc.Data
{
    [Table("Product")]
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}
