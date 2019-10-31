using System;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Models
{
    class Order
    {
        public int id;
        public List<Product> products;

        public Order(int id, List<Product> products)
        {
            this.id = id;
            this.products = products;
        }
    }
}
