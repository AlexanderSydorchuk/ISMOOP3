using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OOP3
{
    class Fraction
    {
        protected long Numerator;
        protected long Denominator;

        public Fraction(long Numerator = 1, long Denominator = 1)
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }

        public Fraction(string fraction)
        {
            Regex regex = new Regex(@"(\d+)\/(\d+)");
            Match match = regex.Match(fraction);

            Numerator = long.Parse(match.Groups[1].Value.ToString());
            Denominator = long.Parse(match.Groups[2].Value.ToString());
        }

        public override string ToString()
        {
            return ($"{Numerator}/{Denominator}");
        }

        public static Fraction operator +(Fraction num1)
        {
            return num1;
        }

        public static Fraction operator-(Fraction num1)
        {
            num1.Numerator = -num1.Numerator;
            return num1;
        }

        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            Fraction result = new Fraction(1, 1);
            if (num1.Denominator == num2.Denominator)
            {
                result.Denominator = num1.Denominator;
                result.Numerator = num1.Numerator + num2.Numerator;
            }
            else if(num1.Denominator % num2.Denominator == 0 || num2.Denominator % num1.Denominator == 0)
            {
                if (num1.Denominator > num2.Denominator)
                {
                    result.Denominator = num1.Denominator;
                    result.Numerator = num1.Numerator + num2.Numerator * (result.Denominator / num2.Denominator);
                }
                else
                {
                    result.Denominator = num2.Denominator;
                    result.Numerator = num1.Numerator * (result.Denominator / num1.Denominator) + num2.Numerator;
                }
            }
            else
            {
                result.Denominator = num1.Denominator * num2.Denominator;
                result.Numerator = num1.Numerator * (result.Denominator / num1.Denominator) + num2.Numerator * (result.Denominator / num2.Denominator);
            }

            return result;
        }

        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            Fraction result = new Fraction(1, 1);
            if (num1.Denominator == num2.Denominator)
            {
                result.Denominator = num1.Denominator;
                result.Numerator = num1.Numerator - num2.Numerator;
            }
            else if (num1.Denominator % num2.Denominator == 0 || num2.Denominator % num1.Denominator == 0)
            {
                if (num1.Denominator > num2.Denominator)
                {
                    result.Denominator = num1.Denominator;
                    result.Numerator = num1.Numerator - num2.Numerator * (result.Denominator / num2.Denominator);
                }
                else
                {
                    result.Denominator = num2.Denominator;
                    result.Numerator = num1.Numerator * (result.Denominator / num1.Denominator) - num2.Numerator;
                }
            }
            else
            {
                result.Denominator = num1.Denominator * num2.Denominator;
                result.Numerator = num1.Numerator * (result.Denominator / num1.Denominator) - num2.Numerator * (result.Denominator / num2.Denominator);
            }

            return result;
        }

        public static Fraction operator *(Fraction num1, Fraction num2)
        {
            Fraction result = new Fraction(1, 1);
            result.Numerator = num1.Numerator * num2.Numerator;
            result.Denominator = num1.Denominator * num2.Denominator;

            return result;
        }

        public static Fraction operator /(Fraction num1, Fraction num2)
        {
            Fraction result = new Fraction(1, 1);
            result.Numerator = num1.Numerator * num2.Denominator;
            result.Denominator = num1.Denominator * num2.Numerator;

            return result;
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static bool operator >(Fraction num1, Fraction num2)
        {
            return num1.Numerator * num2.Denominator > num2.Numerator * num1.Denominator;
        }

        public static bool operator <(Fraction num1, Fraction num2)
        {
            return num1.Numerator * num2.Denominator < num2.Numerator * num1.Denominator;
        }

        public static bool operator >=(Fraction num1, Fraction num2)
        {
            return num1.Numerator * num2.Denominator >= num2.Numerator * num1.Denominator;
        }

        public static bool operator <=(Fraction num1, Fraction num2)
        {
            return num1.Numerator * num2.Denominator <= num2.Numerator * num1.Denominator;
        }

        public static bool operator ==(Fraction num1, Fraction num2)
        {
            return num1.Numerator * num2.Denominator == num2.Numerator * num1.Denominator;
        }

        public static bool operator !=(Fraction num1, Fraction num2)
        {
            return num1.Numerator * num2.Denominator != num2.Numerator * num1.Denominator;
        }

        public static explicit operator double(Fraction num)
        {
            return num.Numerator * 1.0d / num.Denominator * 1.0d;
        }

        public void Normalize()
        {
            int i = 2;
            while (Numerator >= i || Denominator >= i)
            {
                if(Numerator % i == 0 && Denominator % i == 0)
                {
                    Numerator /= i;
                    Denominator /= i;
                }
                else
                {
                    i++;
                }
            }
        }


    }
}
