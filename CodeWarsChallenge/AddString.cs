using System.Numerics;

namespace Codewars_challenge
{
    public class AddString { 
        public static string Add(string a, string b) => BigInteger.Add(BigInteger.Parse(a), BigInteger.Parse(b)).ToString();
    }
}
