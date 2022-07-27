using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drobi
{
    public class RationalNumber : IEquatable<RationalNumber>
    {


        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public RationalNumber()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        

        public static RationalNumber operator +(RationalNumber f1, RationalNumber f2)
        {
            return new RationalNumber(f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
        }




       


        public static bool operator >(RationalNumber f1, RationalNumber f2)
        {
            return (double)f1.Numerator / f1.Denominator > (double)f2.Numerator / f2.Denominator;
        }

        public static bool operator <(RationalNumber f1, RationalNumber f2)
        {
            return (double)f1.Numerator / f1.Denominator < (double)f2.Numerator / f2.Denominator;
        }

        bool IEquatable<RationalNumber>.Equals(RationalNumber other)
        {
            throw new NotImplementedException();
        }



        

    }
}