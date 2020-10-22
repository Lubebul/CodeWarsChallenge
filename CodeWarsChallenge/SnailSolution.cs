using System;
using System.Collections.Generic;

namespace CodeWarsChallenge
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            //TODO controllare che l'array sia veramente una matrice nxn

            if (null == array)
                throw new ArgumentNullException(nameof(array));
                
            if (array.Length == 0) 
                return new int[0];

            if (array.Length != array[0].Length)
            {
                if(array.Length==1 && array[0].Length==0)
                    return new int[0];
                else
                {
                    throw new ArgumentException("Argument is not a matrix NxN", nameof(array));
                }
            }
        
            int arrayRank = array.Length;
            List<int> result = new List<int>();
            
            Sol(0);

            return result.ToArray();

            void Sol(int k)
            {
                if (arrayRank % 2 == 0 && (arrayRank  / 2)-1 == k){
                        result.Add(array[k][k]);
                        result.Add(array[k][k + 1]);
                        result.Add(array[k+1][k + 1]);
                        result.Add(array[k+1][k]);
                        return;
                }

                if (arrayRank % 2 == 1 && arrayRank/2==k){
                    result.Add((array[k][k]));
                    return;
                }

                for (int i = k; i < arrayRank - k; i++){
                    result.Add(array[k][i]);
                }

                for (int i = k + 1; i < arrayRank - k; i++)
                {
                    result.Add(array[i][arrayRank-k-1]);
                }

                for (int i = arrayRank - k - 2; i >= k; i--)
                {
                    result.Add((array[arrayRank-k-1][i]));
                }

                for (int i = arrayRank-k-2; i >k; i--)
                {
                    result.Add(array[i][k]);
                }

                k++;
                Sol(k);
                return;
            }
        }

        public int[] CallSnail()
        {
            int[][] correct = new[] { new[] { 0, 1, 2, 3 }, new[] { 10, 11, 12, 13 }, new[] { 20, 21, 22, 23 }, new[] { 30, 31, 32, 33 } };
            return Snail(correct);
        }

        public int[] CallSnail(int[][] correct)
        {
            return Snail(correct);
        }
    }
}