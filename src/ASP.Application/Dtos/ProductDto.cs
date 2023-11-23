using System.Text.Json.Serialization;

namespace ASP.Application.Dtos
{
    public class ProductDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Description { get; set; }
        public CategoryDto Category { get; set; }
        public int Dimensions { get; set; }
        public int ProductCode { get; set; }
        public string Reference { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
