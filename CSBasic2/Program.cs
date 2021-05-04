using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 오전 오후 구분하기
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침을 먹을 시간 입니다.");
            } else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심을 먹을 시간 입니다.");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다,");
            }

            // 조건문 간단 사용
            double score = 4.2;
            if(score == 4.5)
            {
                Console.WriteLine("신");
            }else if(4.2 <= score)
            {
                Console.WriteLine("교수님의 사랑");
            }else if (3.5 <= score)
            {
                Console.WriteLine("현 체제의 수호자");
            }else if (2.8 <= score)
            {
                Console.WriteLine("일반인");
            }else if (2.3 <= score)
            {
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            }else if (1.75 <= score)
            {
                Console.WriteLine("오락 문화의 선구자");
            }else if (1.0 <= score)
            {
                Console.WriteLine("불가촉천민");
            }else if (0.5 <= score)
            {
                Console.WriteLine("자벌레");
            }else if (0 <= score)
            {
                Console.WriteLine("플랑크톤");
            }else
            {
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");
            }
        }
    }
}
