using System;

namespace CalculatorClass
{
    abstract class Calculator
    {
        /// <summary>
        /// main abstract class calculator
        /// having a multiplication abstract method
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        public abstract void Mul( int firstNum, int secondNum);
    }

    abstract class Multiplication : Calculator
    {
        /// <summary>
        /// abstracting method from parent class Calculator()
        /// overriding mul() method from Calculator() class
        /// and also performing abstract for its child class
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        public override void Mul(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            Console.WriteLine("abstract from Calculator class");
            Console.WriteLine($"Multiplication of {firstNum} * {secondNum} = {result}");            
        }

        public abstract void Div(int firstNum, int secondNum);
    }

    class Division : Multiplication
    {
        /// <summary>
        /// overriding div() method from parent class and also mul() 
        /// method from its parent class.
        /// performing multilevel abstraction.
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        public override void Div(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            Console.WriteLine("abstract from Multiplication class");
            Console.WriteLine($"Division of {firstNum} / {secondNum} = {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Message for Calculator class");
            Division division = new Division();
            division.Mul(10, 5);
            division.Div(5, 10);
        }
    }
}
