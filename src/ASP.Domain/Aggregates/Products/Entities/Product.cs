namespace ASP.Domain.Aggregates.Products.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int Dimensions { get; set; }
        public int ProductCode { get; set; }
        public string Reference { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
