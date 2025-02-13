using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractional
{
    public class RationalNumber : IEquatable<RationalNumber>, IComparable<RationalNumber>
    {
        int numerator;
        int denominator;

        public RationalNumber(int num, int denom)
        {
            numerator = num;
            denominator = denom;

            var gcd = GreatestCommonDenominator(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        // (from Adam Fall 2020) 
        static int GreatestCommonDenominator(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                return GreatestCommonDenominator(b, a % b);
            }
        }

        public bool Equals(RationalNumber other)
        {
            if (other == null)
            {
                return false;
            }
            return this.numerator == other.numerator && this.denominator == other.denominator;
            //The help you gave me about the lab today helped out here^ a lot
        }
        public int CompareTo(RationalNumber? other)
        {
            throw new NotImplementedException();
        }
    }   //I don't get an error on 46 but I am unsure of what is needed for 53
}
