namespace Quiz3

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int odd = 0;
            int even = 0;

            //for문 홀수 합, 짝수 합
            /*
            for (int i = 0; i <= 100; i++) //for(초기화조건; 종료조건; 증가감조건)
            {
                if (i % 2 == 0)
                {
                    even += i;
                }
                else
                {
                    odd += i;
                }
            }
            Console.WriteLine($"{odd}       //홀수");
            Console.WriteLine($"{even}       //짝수");
            */

            //while 문 홀수 합,  짝수 합
            int i = 0;

            while (i <= 100)
            {

                if (i % 2 == 0)
                {
                    even += i;
                }
                else
                {
                    odd += i;
                }
                i++;
            }

            Console.WriteLine($"{odd}       //홀수");
            Console.WriteLine($"{even}       //짝수");
        }
    }
}


