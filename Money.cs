using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class Money
    {
        private int ruble;
        private int penny;

        public Money()
        {
            ruble = 0;
            penny = 0;
        }
        public Money(int ruble,int penny)
        {
            this.ruble = ruble;
            if (penny > 100)
            {
                this.penny = penny % 100;
                this.ruble++;
            }
            else
                this.penny = penny;
        }
        public int Penny
        {
            get { return penny; }
            set { if (value > 100)
                {
                    penny =value % 100;
                    ruble++;
                } }
        }
        public int Ruble
        {
            get { return ruble; }
            set { ruble = value; }
        }
        public int sumInPenny()
        {
            return ruble * 100 + penny;
        }
        public override string ToString()
        {
            return $"\tYour balance = {ruble} ruble, {penny} penny\n";
        }

        public static Money operator +(Money a,Money b)
        {
            int rub = a.ruble + b.ruble;
            int pen = a.penny + b.penny;
            if (pen > 100)
            {
                rub++;
                pen = pen % 100;
            }
            return new Money(rub, pen);
        }
        public static Money operator -(Money a,Money b)
        {
            int rub = a.ruble - b.ruble;
            int pen = a.penny - b.penny;
            if (pen <0)
            {
                rub--;
                pen = 100 + pen;
            }
            return new Money(rub, pen);
        }
        public static Money operator* (Money a,int b)
        {
            int rub = a.ruble * b;
            int pen = a.penny * b;
            if (pen > 100)
            {
                rub += (int)pen / 100;
                pen = pen % 100;
            }
            return new Money(rub, pen);
        }
        public static Money operator /(Money a, int b)
        {
            double number = a.penny + (a.ruble * 100);
            number /= b;
            number /= 100;
            int rub = (int)number /100 ;
            double pen = ((double)number - (int)number) * 100;
            return new Money(rub, (int)pen);
        }
        public static Money operator ++(Money a)
        {
            a.penny++;
            return a;
        } 
        public static Money operator --(Money a)
        {
            a.penny--;
            return a;
        }
        public static bool operator >(Money a,Money b)
        {
            return a.sumInPenny() > b.sumInPenny();
        }
        public static bool operator <(Money a,Money b)
        {
            return a.sumInPenny() < b.sumInPenny();
        }
        public override bool Equals(object obj)
        {
            if(obj is Money)
            {
                Money a = (Money)obj;
                return sumInPenny() == a.sumInPenny();
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public static bool operator ==(Money a,Money b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Money a,Money b)
        {
            return !a.Equals(b);
        }
    }
}
