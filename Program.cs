using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \t Калькулятор v 0.1 Beta");
            Console.WriteLine("Введите первое число");
            decimal n1 = 0;
            try
            {
                n1 = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка формата ввода");
                Console.WriteLine("Только числа - никаких символов и букв");
                Console.ReadKey();
            }
           
            
            Console.WriteLine("Введите второе число");
             decimal n2=0;
            try
            {
                 n2 = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка формата ввода");
                Console.WriteLine("Только числа - никаких символов и букв");
                Console.ReadKey();
            }
            
            Console.WriteLine(" \t Выберите операцию, которую хотите выполнить, из представленных");
            Console.WriteLine(" \t у - умножение");
            Console.WriteLine(" \t д - деление");
            Console.WriteLine(" \t с - сложение");
            Console.WriteLine(" \t в - вычитание");
            switch (Console.ReadLine())
            {
                case "у":
                    {
                        Console.WriteLine("Ответ равен -{0:f4} ", n1 * n2);
                        break;
                    }
                case "д":
                          
                    try

                    {
                        Console.WriteLine("Ответ равен - {0:f4} ", n1 / n2);

                    }

                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Оращайте внимание на корректность ввода чисел");
                    }

                    break;
                case "с":
                    {
                        Console.WriteLine("Ответ равен -{0:f4} ", n1 + n2);
                        break;
                    }

                case "в":
                    {
                        Console.WriteLine("Ответ равен -{0:f4} ", n1 - n2);
                        break;
                    }


                default:
                    Console.WriteLine("Вы сделали неправильный выбор операции");
                    break;


            }
          




                Console.ReadKey();
        }

    }
}
