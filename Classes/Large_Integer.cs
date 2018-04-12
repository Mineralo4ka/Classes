using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Large_integer
    {
        protected internal int[] number = null;
        protected internal byte flag = 0;
        protected internal char symbols = ' ';

        public Large_integer(string number)
        {
            if (number[0] == '-')
            {
                flag = 1;
                this.number = new int[number.Length - 1];
                for (byte i = 1; i < number.Length; ++i)
                {
                    this.number[i - 1] = sbyte.Parse(number[i].ToString());
                }
            }
            else
            {
                flag = 0;
                this.number = new int[number.Length];
                for (byte i = 0; i < number.Length; ++i)
                {
                    this.number[i] = sbyte.Parse(number[i].ToString());
                }
            }
        }
        public Large_integer(byte size)
        {
            number = new int[size];
            for (byte k = 0; k < size; ++k)
            {
                number[k] = 0;
            }
        }

        public static Large_integer operator +(Large_integer number_1, Large_integer number_2)
        {
            if ((number_1.flag == 1 && number_2.flag != 1) || (number_1.flag != 1 && number_2.flag == 1) || number_2.symbols != ' ')
            {
                number_2.symbols = '-';
                return number_1 - number_2;
            }
            else
            {
                Large_integer result = null;
                int min = 0, i = 0;

                if (number_1.number.Length >= number_2.number.Length)
                {
                    result = new Large_integer(Convert.ToByte(number_1.number.Length + 1));
                    for (i = 1; i < result.number.Length; ++i)
                        result.number[i] = number_1.number[i - 1];
                    min = Convert.ToByte(number_2.number.Length);
                }
                if (number_1.number.Length < number_2.number.Length)
                {
                    result = new Large_integer(Convert.ToByte(number_2.number.Length + 1));
                    for (i = 1; i < result.number.Length; ++i)
                        result.number[i] = number_2.number[i - 1];
                    min = Convert.ToByte(number_1.number.Length);
                }

                if (result != null)
                {
                    for (i = min - 1; i >= 0; --i)
                    {
                        if (number_1.number.Length > number_2.number.Length)
                        {
                            result.number[i + result.number.Length - min] += number_2.number[i];
                        }
                        if (number_1.number.Length < number_2.number.Length)
                        {
                            result.number[i + result.number.Length - min] += number_1.number[i];
                        }
                    }
                    for (i = result.number.Length - 1; i > 0; --i)
                        if (result.number[i] > 9)
                        {
                            result.number[i - 1] += 1;
                            result.number[i] -= 10;
                        }
                    result.flag = Convert.ToByte((number_1.flag + number_2.flag) / 2);

                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                    Console.ReadKey();
                    return null;
                }
            }
        }

        public static Large_integer operator -(Large_integer number_1, Large_integer number_2)
        {
            if (number_2.symbols == ' ')
            {
                if (number_1.flag == 1 && number_2.flag != 1)
                {
                    number_2.flag = 1;
                    number_2.symbols = '+';
                    return number_1 + number_2;
                }
                if (number_1.flag != 1 && number_2.flag == 1)
                {
                    number_2.flag = 0;
                    number_2.symbols = '+';
                    return number_1 + number_2;
                }
                if (number_1.flag == 1 && number_2.flag == 1)
                {
                    number_2.flag = 0;
                }
                if (number_1.flag != 1 && number_2.flag != 1)
                {
                    number_2.flag = 1;
                }
            }

            Large_integer result = null;
            int min = 0, i = 0, k = 0;
            byte checker = 0;

            if (number_1.number.Length > number_2.number.Length)
            {
                result = new Large_integer(Convert.ToByte(number_1.number.Length));
                for (i = 0; i < result.number.Length; ++i)
                    result.number[i] = number_1.number[i];
                min = Convert.ToByte(number_2.number.Length);
                checker = 1;
            }
            if (number_1.number.Length < number_2.number.Length)
            {
                result = new Large_integer(Convert.ToByte(number_2.number.Length));
                for (i = 0; i < result.number.Length; ++i)
                    result.number[i] = number_2.number[i];
                min = Convert.ToByte(number_1.number.Length);
                checker = 2;
            }
            if (number_1.number.Length == number_2.number.Length)
            {
                result = new Large_integer(Convert.ToByte(number_1.number.Length));
                min = Convert.ToByte(number_2.number.Length);
                for (k = 0; k < number_1.number.Length; ++k)
                {
                    if (number_1.number[k] > number_2.number[k])
                    {
                        checker = 1;
                        break;
                    }
                    if (number_1.number[k] < number_2.number[k])
                    {
                        checker = 2;
                        break;
                    }
                }
            }

            if (result != null)
            {
                for (i = min - 1; i >= 0; --i)
                {
                    if (number_1.number.Length > number_2.number.Length)
                    {
                        result.number[i + result.number.Length - min] -= number_2.number[i];
                    }
                    if (number_1.number.Length < number_2.number.Length)
                    {
                        result.number[i + result.number.Length - min] -= number_1.number[i];
                    }
                    if (number_1.number.Length == number_2.number.Length)
                    {
                        if (checker == 1)
                            result.number[i + result.number.Length - min] += Convert.ToInt32(number_1.number[i] - number_2.number[i]);
                        else
                            result.number[i + result.number.Length - min] += Convert.ToInt32(number_2.number[i] - number_1.number[i]);
                    }
                }
                for (i = result.number.Length - 1; i > 0; --i)
                    if (result.number[i] < 0)
                    {
                        result.number[i - 1] -= 1;
                        result.number[i] += 10;
                    }
                if ((checker == 1 && number_2.flag == 1) || (checker == 2 && number_1.flag == 1))
                {
                    result.flag = 0;
                }
                if ((checker == 2 && number_2.flag == 1) || (checker == 1 && number_1.flag == 1))
                {
                    result.flag = 1;
                }

                return result;
            }
            else
            {
                Console.WriteLine("Ошибка!");
                Console.ReadKey();
                return null;
            }
        }

        public static Large_integer operator *(Large_integer number_1, Large_integer number_2)
        {
            Large_integer result = new Large_integer(Convert.ToByte(number_1.number.Length + number_2.number.Length));
            int min = 0, max = 0, i = 0, k = 0;
            if (number_1.number.Length >= number_2.number.Length)
            {
                min = Convert.ToByte(number_2.number.Length);
                max = Convert.ToByte(number_1.number.Length);
            }
            if (number_1.number.Length < number_2.number.Length)
            {
                min = Convert.ToByte(number_1.number.Length);
                max = Convert.ToByte(number_2.number.Length);
            }

            if (result != null)
            {
                for (k = min; k > 0; --k)
                    for (i = max; i > 0; --i)
                    {
                        if (number_1.number.Length >= number_2.number.Length)
                            result.number[k + i - 1] += Convert.ToInt32(number_1.number[i - 1] * number_2.number[k - 1]);
                        if (number_1.number.Length < number_2.number.Length)
                            result.number[k + i - 1] += Convert.ToInt32(number_1.number[k - 1] * number_2.number[i - 1]);
                    }

                for (i = result.number.Length - 1; i >= 0; --i)
                    if (result.number[i] >= 10)
                    {
                        result.number[i - 1] += Convert.ToSByte(result.number[i] / 10);
                        result.number[i] = Convert.ToSByte(result.number[i] % 10);
                    }

                if (number_1.flag == 1 || number_2.flag == 1)
                    result.flag = 1;
                if (number_1.flag == 1 && number_2.flag == 1)
                    result.flag = 0;

                return result;
            }
            else
            {
                Console.WriteLine("Ошибка!");
                Console.ReadKey();
                return null;
            }
        }
    }
}