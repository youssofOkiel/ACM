using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order(int id)
        {
            orderId = id;
        }
        public int orderId { get; private set; }

        //datetimeoffset to track time in deifferent time zones 
        public DateTimeOffset? orderDate { get; set; }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        
        public Order Retrieve(int id)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }


        public bool validate()
        {
            bool isvalid = true;

            if (orderDate == null) isvalid = false;
  
            return isvalid;
        }


    }
}
