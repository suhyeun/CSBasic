using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic10
{
    class Program
    {
        public delegate void SendString(string message);

        public static void Hello(string message)
        {
            Console.WriteLine("안녕하세요" + message + "님");
        }

        public static void Goodbye(string message)
        {
            Console.WriteLine("안녕히가세요" + message + "님");
        }

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
            products.Sort((x,y)=> x.Price.CompareTo(y.Price));

            // 출력
            foreach(var item in products)
            {
                Console.WriteLine(item.Name + ":" + item.Price);
            }

            SendString sayHello, sayGoodbye, multiDelegate;
            sayHello = Hello;
            sayGoodbye = Goodbye;

            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("박지윤");
            Console.WriteLine();
            multiDelegate -= sayGoodbye; // sayGoodbye를 뺀다.
            multiDelegate("박지윤");
        }
        
        /*
        private static int SortWithPrice(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
        */
    }
}
