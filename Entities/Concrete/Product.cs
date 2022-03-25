
using Core.Entity;

namespace Entities.Concrete
{
    public class Product: IEntity
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category{ get; set; }
        public List<ProductRecord>? ProductRecords { get; set; }
        public bool IsDeleted { get; set; }

    }

}
