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
            Console.WriteLine("Выберите нужное действие: ");
            Console.WriteLine("1. Большое целое число");
            Console.WriteLine("2. Большая дробь");
            Console.Write("Выбор: ");
            int number = int.Parse(Console.ReadLine());

            switch (number){
                case 1:
                    Console.Write("Введите первое число: ");
                    string num_1 = Console.ReadLine();

                    Console.Write("Введите второе число: ");
                    string num_2 = Console.ReadLine();

                    Large_Integer large = new Large_Integer(num_1, num_2);
                    large.Plus();

                    break;
                case 2:
                    Console.WriteLine("*Данный режим находится в стадии разработки*");
                    break;
            }
            Console.ReadKey();
        }
    }
}
