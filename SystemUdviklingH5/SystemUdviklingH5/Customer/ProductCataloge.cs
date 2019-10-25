using System;
using SystemUdviklingH5.Models;
using System.Collections.Generic;
using System.Text;

namespace SystemUdviklingH5.Customer
{
    class ProductCataloge
    {
        List<Product> products = new List<Product>();
        bool choosingProducts = false;

        private void AddProduct(int id)
        {
            Console.WriteLine("adds product with id {0}", id);
            foreach (var item in products)
            {
                if (item.id == id)
                {
                    CustomerForm.choosenProducts.Add(item);
                }
            }
        }

        private void DisplayCustomerForm()
        {
            choosingProducts = false;
            CustomerForm.showCustomerForm();
        }

        private void GetProductData()
        {
            products.Add(new Product(0, "Rundstyk"));
            products.Add(new Product(1, "LagKage"));
            products.Add(new Product(2, "Rygbrød"));
        }
        
        public void ShowProductCataloge()
        {
            choosingProducts = true;
            Console.Clear();
            GetProductData();

            Console.WriteLine("Choose product");
            foreach (var item in products)
            {
                Console.WriteLine(item.name);
            }
            while (choosingProducts)
            {
                userInput();
            }
        }

        private void userInput()
        {
            var input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "add rundstyk":
                    AddProduct(0);
                    break;
                case "add lagkage":
                    AddProduct(1);
                    break;
                case "add rygbrod":
                    AddProduct(2);
                    break;
                case "show customerform":
                    DisplayCustomerForm();
                    break;
                default:
                    break;
            }
        }
    }
}
