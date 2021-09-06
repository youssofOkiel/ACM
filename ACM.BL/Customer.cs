using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        int id = 0;
        public Customer()
        {
            CustomerId = id +1;
        }
        public int CustomerId { get; private set; }
        public string Email { get; set; }
        public string FirstName { get; set; }

        private string _lastname;
        public string LastName { 
            
            get { return _lastname; } 
            set { _lastname = value; } 
        }
        public string FullName { 
            
            get {
                string fullname = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += '_';
                    }
                    fullname += LastName;
                }
                return fullname; 
            }
        }

        public static int instanceCount { get; set; }

        /// <summary>
        /// retrieve all customer
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// for retrive specific customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        /// <summary>
        /// for save current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// to ensure customer data
        /// </summary>
        /// <returns></returns>
        public bool validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FullName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }


    }
}
