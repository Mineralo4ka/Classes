using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1) Большое целое цисло\n2) Большая дробь\nВыберите: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Clear();
                        Output_of_data num = new Output_of_data();

                        Console.Write("Введите первое число: ");
                        Large_integer a = new Large_integer(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        Large_integer b = new Large_integer(Console.ReadLine());

                        Console.Write("1) Сложение\n2) Вычитание\n3) Умножение\nВыберите: ");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    num.Output(a + b);
                                }
                                break;
                            case "2":
                                {
                                    num.Output(a - b);
                                }
                                break;
                            case "3":
                                {
                                    num.Output(a * b);
                                }
                                break;
                        }
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        Output_of_data num = new Output_of_data();

                        Console.Write("Введите первую дробь: ");
                        Big_shot a = new Big_shot(Console.ReadLine());
                        Console.Write("Введите вторую дробь: ");
                        Big_shot b = new Big_shot(Console.ReadLine());

                        Console.Write("1) Сложение\n2) Вычитание\n3) Умножение\nВыберите: ");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    num.Output(a + b);
                                }
                                break;
                            case "2":
                                {
                                    num.Output(a - b);
                                }
                                break;
                            case "3":
                                {
                                    num.Output(a * b);
                                }
                                break;
                        }
                    }
                    break;
                case "\n":
                    break;
                default:
                    break;
            }
        }
    }
}