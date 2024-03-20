namespace FizzBuzzProject
{
    public class FizzBuzz
    {
        private int actualNumber = 1;
        public FizzBuzz()
        {
        }
        public int getNextNumber()
        {
            return actualNumber++;
        }

        public bool isFizzBuzz(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        public bool isFizz(int number)
        {
            return number % 3 == 0;
        }
        public bool isBuzz(int number)
        {
            return number % 5 == 0;
        }

        public void printAnswerFromOneTo(int endNumber)
        {
            for (int i = 1; i < endNumber; i++)
            {
                Console.WriteLine(getAnswer(i));
            }
        }

        public string getAnswer(int number)
        {
            if (isFizzBuzz(number))
            {
                return "FizzBuzz";
            }
            else if (isFizz(number))
            {
                return "Fizz";
            }
            else if (isBuzz(number))
            {
                return "Buzz";
            }
            else
            {
                return "" + number;
            }

        }
    }
}
