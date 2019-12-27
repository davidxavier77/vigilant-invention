namespace Domain.Product.DTO
{
    public class ProductDTO:BaseDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string AlternateProductName { get; set; }
        public string CreatedBy { get; set; }
        public int Version {get;set;}
    }
}