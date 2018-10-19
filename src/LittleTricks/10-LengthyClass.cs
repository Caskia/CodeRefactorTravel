using System.Collections.Generic;
using System.Linq;

namespace LittleTricks
{
    public class LengthyClass
    {
        public class Bad
        {
            public class Order
            {
                public List<OrderItem> Items { get; set; }

                public void CalculatePrice(object discountRule)
                {
                    //do discount

                    var amount = Items.Select(i => i.Count * i.Price).Sum();
                }
            }

            public class OrderItem
            {
                public int Count { get; set; }

                public decimal Price { get; set; }

                public long ProductId { get; set; }
            }
        }

        public class Good
        {
            public class Order
            {
                public List<OrderItem> Items { get; set; }

                public decimal Amount(PriceService priceService, object discountRule)
                {
                    return priceService.CalculatePrice(this, discountRule);
                }
            }

            public class OrderItem
            {
                public int Count { get; set; }

                public decimal Price { get; set; }

                public long ProductId { get; set; }
            }

            public class PriceService
            {
                public decimal CalculatePrice(Order order, object discountRule)
                {
                    //do discount
                    return order.Items.Select(i => i.Count * i.Price).Sum();
                }
            }
        }
    }
}