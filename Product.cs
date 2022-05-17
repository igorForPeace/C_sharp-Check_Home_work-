using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Check_Home_work_
{
    struct Product
    {
        private string name;
        private int count;
        private int price;
        private double discount;
        private double finalPrice;
        public Product(string name, int count, int price, double discount)
        {
            this.name = name;
            this.count = count;
            this.price = price;
            if (discount==100)
            {
                Console.WriteLine("Скидка не может быть 100%");
                Environment.Exit(0);
            }
            this.discount = discount;
            this.finalPrice = (price - price * (discount / 100)) * count;
        }
        public double FinalPrice
        {
            get { return finalPrice; }
        }
        public void PrintProduct()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Наименование товара: " + this.name);
            Console.WriteLine("Количество: " + this.count);
            Console.WriteLine("Цена: " + this.price);
            Console.WriteLine("Скидка: " + this.discount);
            Console.WriteLine("Общая сумма по товару: " + this.finalPrice);
        }
    }
}
