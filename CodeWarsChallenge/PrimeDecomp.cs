using System;

namespace CodeWarsChallenge
{
    class PrimeDecomp
    {
        public static String factors(int lst)
        {
            return nextPrime(lst).ToString();
        }

        private static int nextPrime(int num)
        {

            if (num == 0 || 1 == num)
                return 2;

            int can = num;
            bool flag = true;
            while (flag)
            {
                can++;
                if (can % 2 == 0){
                    continue;
                }

                for (int i = 3; i <= (can/2); i++ )
                {
                    i++;
                    if (can % i == 0)
                    {
                        break;
                    }

                    return can;

                }

            }


            return 0;


        }

    }
}
