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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
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
            CustomerForm.ShowCustomerForm();
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

            Console.WriteLine("Products we have in our shop: ");
           
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine((i+1) +" " +products[i].name);
            }

            while (choosingProducts)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 4.Shopping cart");
                Console.Write("Enter number of choice:");
                UserInput();
            }

        }

        private void UserInput()
        {
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AddProduct(0);
                    break;
                case 2:
                    AddProduct(1);
                    break;
                case 3:
                    AddProduct(2);
                    break;
                case 4:
                    DisplayCustomerForm();
                    break;
                default:
                    break;
            }
        }
    }
}
