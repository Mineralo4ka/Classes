using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Output_of_data
    {
        public void Output(Large_integer result)
        {
            byte i = 0;

            if (result.flag == 0)
            {
                while (result.number[i] == 0)
                {
                    ++i;
                    if (i == result.number.Length)
                    {
                        --i;
                        break;
                    }
                }

                Console.Write("Результат: ");
                for (; i < result.number.Length; ++i)
                {
                    Console.Write(result.number[i]);
                }
            }

            if (result.flag == 1)
            {
                while (result.number[i] == 0)
                {
                    ++i;
                    if (i == result.number.Length)
                    {
                        --i;
                        break;
                    }
                }

                Console.Write("Результат: -");
                for (; i < result.number.Length; ++i)
                {
                    Console.Write(result.number[i]);
                }
            }
            Console.ReadKey();
        }
        public void Output(Big_shot result)
        {
            byte i = 0;
            if (result.numerator.flag == 1)
            {
                Console.Write("-");
            }
            while (result.numerator.number[i] == 0)
            {
                ++i;
                if (i == result.numerator.number.Length)
                {
                    --i;
                    break;
                }
            }
            for (; i < result.numerator.number.Length; ++i)
                Console.Write(result.numerator.number[i]);
            Console.Write("/");
            i = 0;
            while (result.denominator.number[i] == 0)
            {
                ++i;
                if (i == result.denominator.number.Length)
                {
                    --i;
                    break;
                }
            }
            for (; i < result.denominator.number.Length; ++i)
                Console.Write(result.denominator.number[i]);
            Console.ReadKey();
        }
    }
}
