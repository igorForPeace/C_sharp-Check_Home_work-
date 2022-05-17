using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Check_Home_work_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product a = new Product("Свекла", 5, 10, 20);
            //a.PrintProduct();

            //////////////////
            ///// пример на создание чека

            Product[] b = new Product[5];
            b[0] = new Product("Молоко", 2, 25, 10);
            b[1] = new Product("Яйца", 10, 4, 0);
            b[2] = new Product("Сникерс", 4, 15, 5);
            b[3] = new Product("Хлеб", 1, 19, 0);
            b[4] = new Product("Сыр", 3, 79, 15);


            // печать чека

            Check c = new Check(b);
            c.Print();

            // перегрузка операторов добавления продуктов к существующему чеку

            Product d = new Product("Маслины", 4, 55, 0);
            c.AddProduct(d);
            c.Print();
            c.AddProduct("Пиво Корона", 6, 39, 10);
            c.Print();


        }
    }
}
