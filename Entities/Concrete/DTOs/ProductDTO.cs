using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class ProductDTO
    {
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int CategoryId { get; set; }
        public List<ProductRecordDTO>? ProductRecords { get; set; }
    }
}
