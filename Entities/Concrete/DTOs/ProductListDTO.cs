using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class ProductListDTO
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public ProductRecord ProductRecords { get; set; }
    }
}
