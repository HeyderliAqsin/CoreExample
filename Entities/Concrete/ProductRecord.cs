using Core.Entity;

namespace Entities.Concrete
{
    public class ProductRecord:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? LanguageKey { get; set; }
        public int ProductId { get; set; }
        //public virtual Product Product { get; set; } = null!;
        public bool IsDeleted { get; set; }

    }
}