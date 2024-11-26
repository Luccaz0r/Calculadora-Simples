using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What operation do you want to do?");
            Console.WriteLine("1- ADICTION");
            Console.WriteLine("2- SUBTRACTION");
            Console.WriteLine("3- MULTIPLICATION");
            Console.WriteLine("4- DIVISION \n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;


            switch (operacao)
            {
                case 1:
                    {
                        result = Adiction(num1, num2);
                        break;

                    }
                case 2:
                    {
                        result = Subtraction(num1, num2);
                        break;

                    }
                case 3:
                    {
                        result = Multiplication(num1, num2);
                        break;

                    }
                case 4:
                    {
                        result = Division(num1, num2);
                        break;

                    }

                default:
                    Console.WriteLine("Invalid number, please enter another one.");
                    break;
            }
            Console.WriteLine("The result with numbers {0} and {1} is: {2}", num1, num2, result);




            Console.ReadLine();



        }
        public static int Adiction(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        public static int Subtraction(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }
        public static int Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
        public static int Division(int number1, int number2)
        {
            int result = number1 / number2;
            return result;
        }
    }
}
