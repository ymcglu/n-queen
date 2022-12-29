using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = 8;
        Solution solver = new Solution();     
        IList<IList<string>> solutions = solver.SolveNQueens(n);

        //輸出所有解
        int idx = 0;
        foreach (IList<string> solution in solutions)
        {
            Console.WriteLine("Solution:" + idx);
            foreach (string line in solution)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
            idx++;
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
    }
}

public class Solution
{
    int N;
    char[][] board;
    HashSet<int> columns;    //已經有皇后放置的列
    HashSet<int> diagonals1; //左上到右下的對角線
    HashSet<int> diagonals2; //左下到右上的對角線
    
    public Solution()
    {
        N = 0;
        board = null;
        columns = null;
        diagonals1 = null;
        diagonals2 = null;
    }
    
    public IList<IList<string>> SolveNQueens(int n)
    {
        N = n;
        board = new char[N][];
        for (int i = 0; i < N; i++)
        {
            board[i] = new char[N];
        }
        columns = new HashSet<int>();
        diagonals1 = new HashSet<int>();
        diagonals2 = new HashSet<int>();
        IList<IList<string>> result = new List<IList<string>>();
        FindSolutions(0, result);
        return result;
    }

    public void FindSolutions(int row, IList<IList<string>> result)
    {
        if (row == N)
        {
            IList<string> solution = new List<string>();
            for (int i = 0; i < N; i++)
            {
                solution.Add(new string(board[i]));
            }
            result.Add(solution);
            return;
        }

        for (int col = 0; col < N; col++)
        {
            if (IsSafe(row, col))
            {
                PlaceQueen(row, col);
                FindSolutions(row + 1, result);
                RemoveQueen(row, col);
            }
        }
    }

    public bool IsSafe(int row, int col)
    {
        return !columns.Contains(col)
            && !diagonals1.Contains(row - col)
            && !diagonals2.Contains(row + col);
    }

    public void PlaceQueen(int row, int col)
    {
        board[row][col] = 'Q';
        columns.Add(col);
        diagonals1.Add(row - col);
        diagonals2.Add(row + col);
    }

    public void RemoveQueen(int row, int col)
    {
        board[row][col] = '.';
        columns.Remove(col);
        diagonals1.Remove(row - col);
        diagonals2.Remove(row + col);
    }
}