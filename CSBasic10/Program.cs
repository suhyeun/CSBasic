using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic10
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
       
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() {Name="레드벨벳", Price = 5000},
                new Product() {Name="가나슈", Price = 6000},
                new Product() {Name="벨지안 초코", Price = 5500},
                new Product() {Name="바스크 치즈", Price = 4000},
                new Product() {Name="생크림", Price = 4500}
            };
            // 정렬
            products.Sort(SortWithPrice);

            foreach(var item in products)
            {
                Console.WriteLine(item.Name + ":" + item.Price);
            }


        }

        private static int SortWithPrice(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
