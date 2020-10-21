using System;

namespace Codewars_challenge
{
    public class NextSquare  //dato un quadrato, trovare il successivo numero quadrato tondo
    {
        public static long FindNextSquare(long num)
        {
            return (Math.Sqrt(num)%1 != 0 ? -1 : (long) Math.Pow((Math.Sqrt(num) + 1), 2));
        }
    }
}
