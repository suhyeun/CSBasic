using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        class MethodExample
        {
            public int Power(int x)
            {
                return x * x;
            }

            public int Multi(int x, int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출됨");
            }
        }

        static void Main(string[] args)
        {
            MethodExample me = new MethodExample(); // 인스턴스 메소드, 인스턴스 객체를 만들어야지 사용할 수 있음
            // Power
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));

            // Multi
            Console.WriteLine(me.Multi(52, 273));
            Console.WriteLine(me.Multi(103, 32));

            // Print
            me.Print();
        }
    }
}
