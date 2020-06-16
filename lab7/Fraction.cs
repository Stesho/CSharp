using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lab7
{
    class Fraction
    {
        private readonly int num;
        private readonly int den;

        public Fraction(int n, int d)
        {
            if(d == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            num = n;
            den = d;
        }
        public Fraction(string s)
        {
            string P1 = @"^\d{1,8}\/\d{1,8}$";
            string P2 = @"^\d{1,5}\.\d{1,5}$";
            if (Regex.IsMatch(s, P1))
            {
                string[] nums = s.Split(new char[] { '/' });
                int n = int.Parse(nums[0]);
                int d = int.Parse(nums[1]);
                if (d == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
                {
                    num = n;
                    den = d;
                }
            }
            else if(Regex.IsMatch(s, P2))
            {
                string[] nums = s.Split(new char[] { '.' });
                int d = (int)Math.Pow(10, nums[1].Length);
                int n = int.Parse(nums[0])*d+int.Parse(nums[1]);
                if (d == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
                {
                    num = n;
                    den = d;
                }
            }
        }

        public static Fraction operator +(Fraction temp) => temp;
        public static Fraction operator -(Fraction temp) => new Fraction(-temp.num, temp.den);
        public static Fraction operator +(Fraction temp, Fraction temp1) => new Fraction(temp.num * temp1.den + temp1.num * temp.den, temp.den * temp1.den);
        public static Fraction operator -(Fraction temp, Fraction temp1) => temp + (-temp1);
        public static Fraction operator *(Fraction temp, Fraction temp1) => new Fraction(temp.num * temp1.num, temp.den * temp1.den);
        public static Fraction operator /(Fraction temp, Fraction temp1)
        {
            if(temp1.num == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            return new Fraction(temp.num * temp1.den, temp.den * temp1.num);
        }

        public string ToString(int i)
        {
            if(i == 1)
            {
                return $"{num}/{den}";
            }
            else
            {
                return $"{(double)num / den}";  
            }
        }
        public static bool operator >(Fraction temp, Fraction temp1)
        {
            if (temp.num * temp1.den > temp1.num * temp.den)
                return true;
            return false;
        }
        public static bool operator <(Fraction temp, Fraction temp1)
        {
            if (temp.num * temp1.den < temp1.num * temp.den)
                return true;
            return false;
        }
        public static bool operator >=(Fraction temp, Fraction temp1)
        {
            if (temp.num * temp1.den > temp1.num * temp.den)
                return true;
            return false;
        }
        public static bool operator <=(Fraction temp, Fraction temp1)
        {
            if (temp.num * temp1.den < temp1.num * temp.den)
                return true;
            return false;
        }
        public static bool operator ==(Fraction temp, Fraction temp1)
        {
            if (temp.num * temp1.den == temp1.num * temp.den)
                return true;
            return false;
        }
        public static bool operator !=(Fraction temp, Fraction temp1)
        {
            if (temp.num * temp1.den != temp1.num * temp.den)
                return true;
            return false;
        }

        public static explicit operator int(Fraction temp)
        {
            return temp.num / temp.den;
        }

        public static explicit operator double(Fraction temp)
        {
            return (double)temp.num / temp.den;
        }

        public bool Equals(Fraction temp)
        {
            if (this.num * temp.den == this.den * temp.num)
                return true;
            return false;
        }
    }
}
