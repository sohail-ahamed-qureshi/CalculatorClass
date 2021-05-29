using System;

namespace CalculatorClass
{
    abstract class Calculator
    {
        public abstract void Mul( int firstNum, int secondNum);
    }

    abstract class Multiplication : Calculator
    {
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
