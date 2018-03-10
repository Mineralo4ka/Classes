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

        public Large_Integer(string num)
        {
            number = new int[num.Length];
            if (num.Length != 0 )
            {
                for (int i = 0; i < num.Length; i++)
                {
                    number[i] = int.Parse(num[i].ToString());
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

        public static Large_Integer operator +(Large_Integer number_1, Large_Integer number_2)
        {
            Large_Integer result = null;

            if (number_1.number.Length > number_2.number.Length)
            {
                result = new Large_Integer(number_1.number.Length);
            }

            if (number_2.number.Length > number_1.number.Length)
            {
                result = new Large_Integer(number_2.number.Length);
            }

            if (number_1.number.Length == number_2.number.Length)
            {
                result = new Large_Integer(number_1.number.Length);
            }

            for (int i = 0; i < number_1.number.Length; i++)
            {
                Console.Write("{0} ", number_1.number[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < number_2.number.Length; i++)
            {
                Console.Write("{0} ", number_2.number[i]);
            }
            Console.WriteLine();

            double c = 0;
            for (int i = result.number.Length; i > 0; i--)
            {
                //result.number[i] = number_1.number[i] + number_2.number[i];
                if (number_1.number[i] + number_2.number[i] > 10)
                {
                    c = number_1.number[i] + number_2.number[i];
                    result.number[i] = Convert.ToInt16( c % 10 );
                    result.number[i - 1] = number_1.number[i] + number_2.number[i];
                }
            }

            for (int i = 0; i < result.number.Length; i++)
            {
                Console.Write("{0} ", result.number[i]);
            }

            return result;
        }
    }
}
