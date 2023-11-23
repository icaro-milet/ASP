using System.Text.Json.Serialization;

namespace ASP.Application.Dtos
{
    public class CategoryDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
