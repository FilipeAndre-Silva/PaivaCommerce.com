namespace PaivaCommerce.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int Amount { get; set; }
    }
}