using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharp01.Struct
{
    struct Score
    {
        public string Name;
        public int Kor;
        public int Eng;
        public int Tot;
        public int Avg;
        public int Graph;

    }
    class T01_Struct
    {
        static void Main()
        {
            Score[] scores = new Score[3];
            scores[0].Name = "홍길동";
            scores[0].Kor = 90;
            scores[0].Eng = 80;
            scores[0].Tot = scores[0].Kor + scores[0].Eng;
            scores[0].Avg = (scores[0].Tot / 2);
            scores[1].Name = "백두산";
            scores[1].Kor = 90;
            scores[1].Eng = 70;
            scores[1].Tot = scores[1].Kor + scores[1].Eng;
            scores[1].Avg = (scores[1].Tot / 2);
            scores[2].Name = "김좌진";
            scores[2].Kor = 80;
            scores[2].Eng = 80;
            scores[2].Tot = scores[2].Kor + scores[2].Eng;
            scores[2].Avg = (scores[2].Tot / 2);

            for (int i = 0; i < 3; i++)
            {
                scores[i].Graph = scores[i].Avg / 5;
            }
            Console.WriteLine("이름\t 총정 \t 평균\t 막대 그래프");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{scores[i].Name}\t {scores[i].Kor}\t {scores[i].Eng}\t");
                for (int j = 0; j < scores[i].Graph; j++)
                {
                    Console.Write("ㅁ");
                }
                Console.WriteLine();
            }
        }
    }
}
