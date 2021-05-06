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

            int i = 0;
            int[] intArray2 = { 52, 273, 32, 65, 103};
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

        }
    }
}
