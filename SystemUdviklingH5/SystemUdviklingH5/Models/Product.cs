using System;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Models
{
    class Product
    {
        public int id;
        public string name;

        public Product()
        {
        }

        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
