using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class ProductRecordDTO
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string LanguageKey{ get; set; }
    }
}
