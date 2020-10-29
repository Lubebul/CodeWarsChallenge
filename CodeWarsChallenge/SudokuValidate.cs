using System.Collections.Generic;



namespace CodeWarsChallenge
{
    public class SudokuValidate
    {
        public static bool ValidateSolution(int[][] board)
        {
            //TODO
            var riga= new List<int>();
            var colonna= new List<int>();
            
            for (int i = 0; i < board.Length; i++){
                riga.Clear();
                colonna.Clear();
                riga.Add(0);
                colonna.Add(0);
                for (int j = 0; j < board[0].Length; j++) {

                    if (riga.Contains(board[i][j]) || colonna.Contains(board[j][i]))
                        return false;
                    riga.Add(board[i][j]);
                    colonna.Add(board[j][i]);
                }
            }

            var square= new List<int>();

            for (int k = 1; k < 4; k++){
                for (int z = 1; z < 4; z++) {
                    square.Clear();
                    for (int i = 3 * (k - 1); i < (3 * k) - 1; i++)
                    {
                        for (int j = 3 * (z - 1); j < (3 * z) - 1; j++)
                        {

                            if (square.Contains(board[i][j]))
                                return false;
                            square.Add(board[i][j]);

                        }
                    }
                }
            }

            return true;

        }
    }
}
