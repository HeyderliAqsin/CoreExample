

using Core.Entity;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public  int Id { get; set; }
        public string? SanitizedName { get; set; }
        public bool IsDeleted { get; set; }
        public List<CategoryRecord>? CategoryRecords { get; set; }
    }
}
