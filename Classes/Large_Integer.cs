using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Large_Integer
    {
        private int[] number = null;
        private bool minus = false;

        public Large_Integer(string num)
        {
            number = new int[num.Length];
            if (num.Length != 0 )
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    if (num[0] == '-')
                    {
                        minus = true;
                        break;
                    }
                    number[number.Length - i - 1] = int.Parse(num[i].ToString()); 
                }
            } else
            {
                Console.WriteLine("Вы не ввели число");
            }
        }

        public Large_Integer(int len)
        {
            this.number = new int[len];
            for (int i = 0; i < len; i++)
            {
                this.number[i] = 0;
            }
        }

        public static Large_Integer operator + (Large_Integer number_1, Large_Integer number_2)
        {
            Large_Integer result = null;
            int digit;

            if (number_1.number.Length > number_2.number.Length)
            {
                result = new Large_Integer(number_1.number.Length + 1);
            } else if (number_2.number.Length > number_1.number.Length)
            {
                result = new Large_Integer(number_2.number.Length + 1);
            }else if (number_1.number.Length == number_2.number.Length)
            {
                result = new Large_Integer(number_1.number.Length + 1);
            }
         
            for (int i = 0; i < result.number.Length - 1; i++)
            {
                digit = number_1.number[i] + number_2.number[i];
                if (digit >= 10)
                {
                    result.number[i] += digit - 10;
                    result.number[i + 1] += 1;
                } else
                {
                    result.number[i] += digit;
                }
            }

            for (int i = 0; i <= result.number.Length - 1; i++)
            {
                Console.Write(result.number[i]);
            }

            return result;
        }

        public static Large_Integer operator - (Large_Integer number_1, Large_Integer number_2)
        {
            Large_Integer result = null;
            int digit;

            if (number_1.number.Length > number_2.number.Length)
            {
                result = new Large_Integer(number_1.number.Length + 1);
            }
            else if (number_2.number.Length > number_1.number.Length)
            {
                result = new Large_Integer(number_2.number.Length + 1);
            }
            else if (number_1.number.Length == number_2.number.Length)
            {
                result = new Large_Integer(number_1.number.Length + 1);
            }

            for (int i = 0; i < result.number.Length - 1; i++)
            {
                digit = number_1.number[i] - number_2.number[i];
                if (digit <= 0)
                {
                    result.number[i] += (number_1.number[i] + 10) - number_2.number[i];
                    result.number[i + 1] -= 1;
                }else
                {
                    result.number[i] += digit;
                }
            }

            for (int i = 0; i <= result.number.Length - 1; i++)
            {
                Console.Write(result.number[i]);
            }

            return result;
        }
    }
}
