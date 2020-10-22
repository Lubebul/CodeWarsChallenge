using System.Collections.Generic;

namespace CodeWarsChallenge
{
    public class PIN
    {
        private static string [][] digits=
            new string[][]
            {
                new[] {"0", "8"}, new[] { "1", "2", "4"}, new[] { "1", "2", "3", "5"}, new[] { "2", "3", "6"}, new[] { "1", "4", "5", "7"},
                new[] { "2", "4", "5", "6", "8"}, new[] { "3", "5", "6", "9"}, new[] { "4", "7", "8"}, new[] { "5", "7", "8", "9", "0"}, new[] { "6", "8", "9" }
            };
        public static List<string> GetPINs(string observed) {
            List<string> result= new List<string>();

            result.Add("");
            Sol(0);

            result.Sort();
            return result;

            

            void Sol(int pos) {
                if (pos == observed.Length)
                    return;
                
                int Count = result.Count;
                int dig = int.Parse(observed[pos].ToString());
                
                for (int j=0; j<Count; j++) {
                    for (int i = 0; i < digits[dig].Length; i++) {
                        if (i == (digits[dig].Length - 1)) {
                            result[j] = result[j] + digits[dig][i];
                            continue;
                        }

                        result.Add(result[j] + digits[dig][i]);
                    }
                }
                pos++;
                Sol(pos);
            }



        }
    }
}
