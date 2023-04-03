using System.Collections.Generic;
using System.Linq;

namespace Decisive.Wizard.Domain.Orders {

    public class Order {

        public int Id { get; set; }

        public List<OrderItem> Items { get; set; } = default!;

        public DateTime CreatedDate { get; set; }

        public decimal TotalPrice => Items.Sum(i => i.Price);
    }
}