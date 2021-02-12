using Core.Entities;

namespace Entity.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
