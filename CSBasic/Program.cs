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

            // 자료형 Data Type
            // Integer
            Console.WriteLine(53 + 272 - 123);
            Console.WriteLine(53 * 3 - 2);
            Console.WriteLine(14 / 2); // 7
            Console.WriteLine(14 / 3); // 4
            Console.WriteLine(14 % 3); // 2

            // 실수 Real Number
            Console.WriteLine(13.123);

            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine(14.0 / 2.0); // 7.0
            Console.WriteLine(14.0 / 3.0); // 4.66667
            // Console.WriteLine(14.0 % 3.0);
             Console.WriteLine(14 / 3); // 4
            Console.WriteLine(14.0 / 3); // 4
            Console.WriteLine(14/ 3.0); // 4.66667
            Console.WriteLine(14.0 / 3.0); // 4.66667

            // Character
            Console.WriteLine('A'); // 문자

            // String
            Console.WriteLine("A"); // 문자열

            // Escape Character
            Console.WriteLine("\t 탭 \\ 역슬래시 \n 개행 \"");
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자\t정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보\t과학고");
            Console.WriteLine("미림여자정보과\t학고");
            Console.WriteLine("미림여자정보과학\t고");
            Console.WriteLine("미림여자정보과학고\t");

            // 문자열 연산자
            // concat concatenate operator
            // concatenation operator
            Console.WriteLine("ABC" + "EFG");
            Console.WriteLine('A' + 'E'); // 134
            Console.WriteLine("ABC" + 'E');

            Console.WriteLine("ABC"[2]);
            // Console.WriteLine("ABC"[3]); // 예외 발생

            // bool
            bool isPlay = true;
            bool isDeath = false;

            // compatrison operator
            Console.WriteLine(52 == 163);
            Console.WriteLine(52 != 163);
            Console.WriteLine(52 > 163);
            Console.WriteLine(52 < 163);
            Console.WriteLine(52 >= 163);
            Console.WriteLine(52 <= 163);

            // Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            // 단항연산자 - unary operator
            Console.WriteLine(!(true));
            int i = 0;
            i++;

            // 이항연산자 - binary operator
            i = 1 + 2;


            // 삼항연산자 - ternary operator
            int j;
            j = (j>3) ? 0 : 1;

            // Console.WriteLine(3 < i < 10);
            Console.WriteLine(3 < i && i < 8);
            Console.WriteLine(3 > i || i > 8);
            Console.WriteLine(i < 3 || 8 < i);


        }
    }
}
