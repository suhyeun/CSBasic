using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
    class MyMath
    {
        public static double PI = 3.141592;
        public static void Greeting()
        {
            // Console.WriteLine(someNumber); // 클래스변수에서 멤버변수 접근 불가능
            Console.WriteLine("Greeting");
        }
    }

    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }

    class Program
    {

        class FirstClass
        {

        }

        class SecondClass
        {

        }


        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();

            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100)); // 100 미만
            Console.WriteLine(random.Next(10, 100)); // 10 이상 100 미만
            Console.WriteLine(random.Next(1, 19)); // 우리반... ^^

            Console.WriteLine();

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            Console.WriteLine();

            // List
            /*List<int> list = new List<int>();
            list.Add(273);
            list.Add(52);
            list.Add(32);
            list.Add(64);*/

            List<int> list = new List<int>() { 52, 273, 32, 64 };
            list.Remove(52);

            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
                /*list.Remove(item);*/ // 에러 발생
            }

            Console.WriteLine();

            // Math Class
            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.Max(52, 173));
            Console.WriteLine(Math.Min(52, 173));

            Console.WriteLine();

            Product product = new Product();
            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + " : " + product.price + "원");

            Product productA = new Product() { name = "짜장면", price = 5500 };
            Product productB = new Product() { name = "짬뽕", price = 8000 };
            Product productC = new Product() { name = "탕수육" };
            Product productD = new Product() { price = 20000 };
            Product productE = new Product() { price = 25000, name = "양장피" };


        }
    }
}
