using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Large_Integer
    {
        public int[] number = null;
        private bool flag = false;
        

        public Large_Integer(string num)
        {
            number = new int[num.Length];
            if (num.Length != 0 )
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    /*if (num[0] == '-')
                    {
                        flag = true;
                        break;
                    }*/
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
            int i = 0;

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
         
            for (i = 0; i < result.number.Length - 1; i++)
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

            i = result.number.Length - 1;
            while (result.number[i] == 0)
            {
                i--;
                if (i == -1)
                {
                    i++;
                    break;
                }
            }
            for (; i >= 0; i--)
            {
                Console.Write(result.number[i]);
            }

            return result;
        }

        public static Large_Integer operator - (Large_Integer number_1, Large_Integer number_2)
        {
            Large_Integer result = null;
            int checker = 0, min = 0;
            int i = 0;

            if (number_1.number.Length > number_2.number.Length)
            {
                result = new Large_Integer(number_1.number.Length);
                min = Convert.ToInt32(number_2.number.Length);
                checker = 1;
            }
            if (number_2.number.Length > number_1.number.Length)
            {
                result = new Large_Integer(number_2.number.Length);
                min = Convert.ToInt32(number_1.number.Length);
                checker = 2;
            }
            if (number_1.number.Length == number_2.number.Length)
            {
                result = new Large_Integer(number_1.number.Length);
                min = number_2.number.Length;
                for (i = number_1.number.Length - 1; i >= 0; i--)
                {
                    if (number_1.number[i] > number_2.number[i])
                    {
                        checker = 1;
                        break;
                    }
                    if (number_1.number[i] < number_2.number[i])
                    {
                        checker = 2;
                        break;
                    }
                }
            }

            if (number_1.number.Length == number_2.number.Length)
            {
                if (checker == 1)
                {
                    for (i = 0; i < min; i++)
                    {
                        result.number[i] += number_1.number[i] - number_2.number[i];
                        if (result.number[i] < 0)
                        {
                            result.number[i] += 10;
                            result.number[i + 1] -= 1;
                        }
                    }
                    number_1.flag = false;
                }
                if (checker == 2)
                {
                    for (i = 0; i < min; i++)
                    {
                        result.number[i] += number_2.number[i] - number_1.number[i];
                        if (result.number[i] < 0)
                        {
                            result.number[i] += 10;
                            result.number[i + 1] -= 1;
                        }
                    }
                    number_1.flag = true;
                }
            }

            if (number_1.flag == true)
            {
                Console.Write("-");
                i = result.number.Length - 1;
                while (result.number[i] == 0)
                {
                    i--;
                    if (i == -1)
                    {
                        i++;
                        break;
                    }
                }
                for (; i >= 0; i--)
                {
                    Console.Write(result.number[i]);
                }            
            }
            
            if (number_1.flag == false)
            {
                i = result.number.Length - 1;
                while (result.number[i] == 0)
                {
                    i--;
                    if (i == -1)
                    {
                        i++;
                        break;
                    }
                }
                for (; i >= 0; i--)
                {
                    Console.Write(result.number[i]);
                }
            }

            return result;
        }
    }
}
