using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenge
{
    class PerfectPower
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            int i = 2;
            float aux = 0;
            do
            {
                aux = (float) Math.Pow(n, 1.0/i);

                if (aux % 1 == 0)
                    return ((int) aux, i);
                i++;

            } while (aux > 2);

            return null;
        }
    }
}
