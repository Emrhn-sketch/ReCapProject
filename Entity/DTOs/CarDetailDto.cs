using Core.Entities;

namespace Entity.DTOs
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public float DailyPrice { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
      
    }
}