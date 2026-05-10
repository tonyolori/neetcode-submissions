public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char value = board[r][c];

                if (value == '.') {
                    continue;
                }

                string rowKey = value + "in row " + r;
                string colKey = value + "in col " + c;
                string boxKey = value + "in box " + (r / 3) + "-" + (c / 3);

                if (!seen.Add(rowKey) || !seen.Add(colKey) || !seen.Add(boxKey)) {
                    return false;
                }
            }
        }
        return true;
    }
}
