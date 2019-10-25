using System;
using SystemUdviklingH5.Models;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Customer
{
    class ProductCataloge
    {
        List<Product> products = new List<Product>();

        private void AddProduct(int id)
        {

        }

        private void DisplayCustomerForm()
        {

        }

        private void GetProductData()
        {
            products.Add(new Product(0, "Rundstyk"));
            products.Add(new Product(1, "LagKage"));
            products.Add(new Product(2, "Rygbrød"));
        }
        
        public void ShowProductCataloge()
        {
            Console.Clear();
            GetProductData();

            Console.WriteLine("Choose product");
            foreach (var item in products)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
