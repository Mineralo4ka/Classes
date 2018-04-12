using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Big_shot
    {
        protected internal Large_integer numerator = null;
        protected internal Large_integer denominator = null;

        public Big_shot(string shot)
        {
            char divider = '/';
            string[] str = shot.Split(divider); ;

            numerator = new Large_integer(str[0]);
            denominator = new Large_integer(str[1]);

            if (numerator.flag == 1 && denominator.flag == 1)
                denominator.flag = 0;
            if (numerator.flag != 1 && denominator.flag == 1)
            {
                numerator.flag = 1;
                denominator.flag = 0;
            }
        }
        public Big_shot()
        { }

        public static Big_shot operator +(Big_shot shot_1, Big_shot shot_2)
        {
            Big_shot result = new Big_shot();

            result.denominator = shot_1.denominator * shot_2.denominator;
            result.numerator = (shot_1.numerator * shot_2.denominator) + (shot_2.numerator * shot_1.denominator);

            return result;
        }

        public static Big_shot operator -(Big_shot shot_1, Big_shot shot_2)
        {
            Big_shot result = new Big_shot();

            result.denominator = shot_1.denominator * shot_2.denominator;
            result.numerator = (shot_1.numerator * shot_2.denominator) - (shot_2.numerator * shot_1.denominator);

            return result;
        }

        public static Big_shot operator *(Big_shot shot_1, Big_shot shot_2)
        {
            Big_shot result = new Big_shot();

            result.numerator = shot_1.numerator * shot_2.numerator;
            result.denominator = shot_1.denominator * shot_2.denominator;

            return result;
        }
    }
}