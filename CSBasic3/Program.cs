using System;
using System.Threading;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = new int[100];
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
            // Console.WriteLine(intArray[100]); // 범위 초과, 예외 발생
            // Console.WriteLine(intArray[-1]); // 음수 사용 불가, 예외 발생

            // while / do while
            int i = 0;
            int[] intArray2 = { 52, 273, 32, 65, 103 };
            while (i < intArray2.Length)
            {
                Console.WriteLine(i + "번쨰 출력: " + intArray2[i]);
                i++;
            }

            string input;
            do
            {
                Console.WriteLine("입력종료(exit): ");
                input = Console.ReadLine();
            } while (input != "exit");

            // for
            for (int j = '가'; j <= '힣'; j++)
            {
                Console.Write((char)j);
            }


            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            for (int k = intArray3.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(intArray3[k]);
            }

            Console.WriteLine();

            for (int k = intArray3.Length; k > 0; k--)
            {
                Console.WriteLine(intArray3[k - 1]);
            }

            string[] fruits = {"사과", "수박", "체리", "자두", "딸기", "망고"};
            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            for(i = 0; i<10; i++)
            {
                for(int j = 0; j<i+1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10-i-1; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            // 대소문자 변환
            string input3 = "Potato Tomato";
            Console.WriteLine(input3.ToUpper());
            Console.WriteLine(input3.ToLower());
            input3.ToLower(); // 헛고생
            Console.WriteLine(input3);

            string foods = "감자 고구마 토마토";
            string[] foodsArray = foods.Split(new char[] { ' ' });
            foreach(var item in foodsArray)
            {
                Console.WriteLine(item);
            }

            // 환경변수의 path텍스트 값을 가져와서 \를 \\로 치환해서 넣어준다 
            string path = "C:\\Program Files\\heroku\\bin";
            string[] paths = path.Split(new char[] { ';' });
            foreach(var item in paths)
            {
                Console.WriteLine(item);
            }

            string dirtyInput = " text  um \n\t";
            Console.WriteLine("[" + dirtyInput + "]");
            Console.WriteLine("[" + dirtyInput.Trim() + "]");

            string[] foodsArray2 = { "감자", "고구마", "토마토", "가지"};
            Console.WriteLine(string.Join(" ", foodsArray2)); // space 1개
            Console.WriteLine(string.Join(",", foodsArray2));
            Console.WriteLine(string.Join(";", foodsArray2));
            Console.WriteLine(string.Join(" ", foodsArray2)); // tab


            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[      ]");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[#     ]");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[##     ]");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[###    ]");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[####   ]");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[#####  ]");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[###### ]");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("[#######]");
            Thread.Sleep(1000);


            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__0");
                else if (x % 3 == 1)
                    Console.WriteLine("_^0");
                else
                    Console.WriteLine("^_0");

                Thread.Sleep(1000);
                x++;
                
            }

        }

    }
}
