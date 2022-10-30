namespace ProductManagementApi.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }

        public string? Type {get; set;}

        public bool Active {get; set;}
    }
}