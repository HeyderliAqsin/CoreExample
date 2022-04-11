

using Core.Entity;

namespace Entities.Concrete
{
    public class CategoryRecord : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int LanguageId { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        //public virtual Category? Category { get; set; }
    }
}
