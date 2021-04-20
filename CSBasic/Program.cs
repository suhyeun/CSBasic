using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // var keyword는 지역변수(메서드 내)에서만 사용가능

            // keyword
            // int as;

            // context keyword
            var name = "김수현";
            // var var = "김수현";
            // var abcd = "asdf";

            // 식별자 Identifier
            int alpha;
            int Alpha;
            // int break; // 예약어라서 X
            // int 234asf; // 숫자로 시작하므로 X
            // int has bs; // 띄어쓰기 X
            // int 🎈🎁; // 이모지 X
            int 한글; // 지양합시다

            // inline comment
            /*
             * comment
             */
            /// xml comment 

            // 출력
            Console.Write("이건 안개행");
            Console.Write("입니당");
            Console.WriteLine("이건 개행");
            Console.WriteLine("입니당");

        }
    }
}
