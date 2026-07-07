public class Solution {
    public void Solve(char[][] board) {
        var queue = new Queue<(int row, int col)>();

        var n = board.Length;
        var m = board[0].Length;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (i == 0 || i == n - 1 || j == 0 || j == m - 1) {
                    if (board[i][j] == 'O') {
                        queue.Enqueue((i, j));
                        board[i][j] = 'E';
                    }  
                }
            }
        }

        int[] dirs = { -1, 0, 1, 0, -1 };

        while (queue.Count > 0) {
            var (currentRow, currentCol) = queue.Dequeue();

            for (int k = 0; k < 4; k++) {
                int nextRow = currentRow + dirs[k];
                int nextCol = currentCol + dirs[k + 1];

                if (nextRow >= 0 && nextRow < n && nextCol >= 0 && nextCol < m && board[nextRow][nextCol] == 'O') {
                    board[nextRow][nextCol] = 'E';
                    queue.Enqueue((nextRow, nextCol));
                }
            }
        }

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (board[i][j] == 'O')
                    board[i][j] = 'X';
                else if (board[i][j] == 'E')
                    board[i][j] = 'O';
            }
        }
    }
}
