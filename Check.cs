using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Check_Home_work_
{
    struct Check
    {
        static Random rnd = new Random();
        private Product[] products;
        private double total;
        public Check(Product [] array)
        {
            total = 0;
            products = new Product[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                this.products[i] = array[i];
               
            }
        }
        public void Print()
        {
            Console.WriteLine("====Магазин Екатерина====");
            Console.WriteLine("Чек №" + rnd.Next(1, 457));
            Console.WriteLine("Дата и время: " + DateTime.Now);
            Console.WriteLine("Список продуктов: ");
            for (int i = 0; i < this.products.Length; i++)
            {
                this.products[i].PrintProduct();
                this.total += this.products[i].FinalPrice;
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Итого к оплате: " + this.total);
            Console.WriteLine("-------------GOOD BYE-------------");
            Console.WriteLine();
            this.total = 0;
        }
        public void AddProduct(Product other)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = other;
        }
        public void AddProduct(string name, int count, int price, double discount)
        {
            this.AddProduct(new Product(name, count, price, discount));
        }
    }
}
