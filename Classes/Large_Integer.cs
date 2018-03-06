using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Large_Integer
    {
        private int[] number_1 = null, number_2 = null;

        public Large_Integer(string num_1, string num_2)
        {
            number_1 = new int[num_1.Length];
            if (num_1[0] != '\n')
            {
                for (int i = 0; i < num_1.Length; i++)
                {
                    number_1[i] = int.Parse(num_1[i].ToString());
                }

                for (int i = 0; i < number_1.Length; i++)
                {
                    Console.Write("{0} ", number_1[i]);
                }
            } else if (num_1[0] == '\n')
            {
                Console.WriteLine("Вы не ввели первое число");
            }

            Console.WriteLine();

            number_2 = new int[num_2.Length];
            for (int i = 0; i < num_2.Length; i++)
            {
                number_2[i] = int.Parse(num_2[i].ToString());
            }

            for (int i = 0; i < number_2.Length; i++)
            {
                Console.Write("{0} ", number_2[i]);
            }
        }

        public void Plus()
        {

        }
    }
}
