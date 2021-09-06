using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem(int id)
        {
            orderItemId = id;

        }

        public int orderItemId { get; private set; }

        public int productId { get; set; }
        public decimal? purchasePrice { get; set; }

        public int quantity { get; set; }


        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public OrderItem Retrieve(int id)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }


        public bool validate()
        {
            bool isvalid = true;

            if (purchasePrice == null) isvalid = false;
            if (quantity <= 0) isvalid = false;
            if (productId <= 0) isvalid = false;

            return isvalid;
        }
    }
}
