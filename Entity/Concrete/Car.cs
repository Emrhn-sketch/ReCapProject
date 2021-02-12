using Core.Entities;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public int ModelYear { get; set; }
        public float DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
