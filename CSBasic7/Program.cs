using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{

    class Products
    {
        private List<string> list = new List<string>();
        public Products()
        {
            list.Add("닭발");
            list.Add("곱창");
            list.Add("막창");
            list.Add("대창");
            list.Add("계란찜");
            list.Add("참치마요주먹밥");
        }

        public string this[int i]
        {
            get { return list[i]; }
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }

    class Wanted<T>
        // where T : Student
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }

    class Student
    {
        public override string ToString()
        {
            return "학생";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Products ps = new Products();
            Random rs = new Random();
            int i = rs.Next(0, 6);
            Console.WriteLine(ps[i]);

            Wanted<string> ws = new Wanted<string>("String");
            Wanted<int> wi = new Wanted<int>(42);
            Wanted<Student> wstu = new Wanted<Student>(new Student());

            Console.WriteLine(ws);
            Console.WriteLine(wi);
            Console.WriteLine(wstu);
        }
    }
}
