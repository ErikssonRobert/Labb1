using System;
namespace Calculator
{
    public class Calculator
    {
        private int firstNumber;
        public int FirstNumber {
            get { return firstNumber; }
            set { firstNumber = Math.Abs(value); }
        }
        private int secondNumber;
        public int SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = Math.Abs(value); }
        }
        private int numberInMemory;
        public int NumberInMemory
        {
            get { return numberInMemory; }
            set { numberInMemory = Math.Abs(value); }
        }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        public int SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public int MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public int SumInBetween()
        {
            int Sum = 0;
            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                Sum += i;
            }

            return Sum;
        }

        public override string ToString()
        {
            return String.Format("First number: {0}\n" +
                                 "Second number: {1}\n" +
                                 "Number in memory: {2}",
                                 FirstNumber,
                                 SecondNumber,
                                 NumberInMemory);
        }
    }
}
