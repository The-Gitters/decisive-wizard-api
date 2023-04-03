using Decisive.Wizard.Domain.Catalog;

namespace Decisive.Wizard.Domain.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }

        public Item Item { get; set; } = default!;

        public int Quantity { get; set; }

        public decimal Price => Item.Price * Quantity;

    }
}