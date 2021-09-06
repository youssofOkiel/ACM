using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product
    {
        public Product(int id)
        {
            productId = id;
        }
        public int productId { get; private set; }
        public string productName { get; set; }
        public string description { get; set; }

        public decimal? currrntPrice { get; set; }

        public bool validate()
        {
            bool isvalid = true;

            if (string.IsNullOrWhiteSpace(productName)) isvalid = false;
            if (string.IsNullOrWhiteSpace(description)) isvalid = false;
            if ( currrntPrice <= 0 ) isvalid = false;
           
            return isvalid;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public Product Retrieve(int productId )
        {

            return new Product();
        }

        public bool Save()
        {
            return true;
        }


    }
}
