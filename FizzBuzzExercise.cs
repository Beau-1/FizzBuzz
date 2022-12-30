using System;

namespace FizzBuzz
{
    class Program
    {
        public static string FizzBuzz(int number)
        {
            var answer = "";


            if (number % 3 == 0 && number % 5 == 0)
            {
                answer = "FizzBuzz";
            }

            else if (number % 3 == 0)
            {
                answer = "Fizz";
            }

            else if(number % 5 == 0)
            {
                answer = "Buzz";
            }

            return answer;

        }
        static void Main(string[] args)
        {
            string result = FizzBuzz(15); 



            Console.WriteLine(result);
            

        }
    }
}
