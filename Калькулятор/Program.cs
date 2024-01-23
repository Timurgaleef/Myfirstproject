using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Введите число 1");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите знак '+' '-' '/' '*' ");


           string Action = Console.ReadLine();



             switch (Action)

            {
                case "+":

                Console.WriteLine(firstValue + secondValue);

                    break;

                case "-":

                    Console.WriteLine(firstValue - secondValue);

                    break;

                case "*":

                    Console.WriteLine(firstValue * secondValue);

                    break;


                    case "/":

                    Console.WriteLine(firstValue / secondValue);     

                    break;


                default:

                    Console.WriteLine("Ошибка!");

                    break;




            }

            

            Console.ReadLine();
        }
    }
}
