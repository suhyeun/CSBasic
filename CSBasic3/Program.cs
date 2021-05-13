using System;

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

        }

    }
}
