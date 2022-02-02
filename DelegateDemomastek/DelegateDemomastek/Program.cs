using System;

namespace DelegateDemomastek
{ 
    //1
    delegate int CalculatorDelegate(int first, int second);
    class Program
    {
        //2
        
        //add
        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        //multiply
        static int MultiplyNumbers(int number1, int number2)
        {
            return number1 * number2;
        }
        static void Main(string[] args)
        {
            //3 delegate instance - point to a method
            //CalculateorDelegate demo1 = new CalculatorDelegate(AddNumbers);
            CalculatorDelegate demo1 = AddNumbers;
            

            //4 invoke Delegate
            
            //add
            int result = demo1(4, 6);
            Console.WriteLine("Addition : " + result);

            //multiply
            int result1 = demo1(4, 6);
            Console.WriteLine("Multiplication : " + result1);

            Console.WriteLine("----------------");

            //.net fw 3.5 - 2008 Lambda expression
            //merge step 2 + 3

            // (input param) => expression

            //add
            CalculatorDelegate demo2 = (a, b) => a + b;
            result = demo2(2, 4);
            Console.WriteLine("Addition = " + result);


            //multiply
             demo2 = (a, b) => a * b;
            result = demo2(2, 4);
            Console.WriteLine("Multiplication = " + result);

            //subtract
             demo2 = (a, b) => a - b;
            result = demo2(2, 4);
            Console.WriteLine("Subtraction = " + result);

            //division
             demo2 = (a, b) => a / b;
            result = demo2(2, 4);
            Console.WriteLine("Division = " + result);

            //Action / Action<T> : method that do not contain any return type or retrun type is void

            //func<> :point a method and  returns a value

            //Predicate: special kind of func used for comperision
            
        }
    }
}
