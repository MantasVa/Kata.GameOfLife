using System;

namespace Kata.GameOfLife
{
    public class GameBoard : ICloneable
    {
        public char[,] Board { get; }
        public int Rows { get; }
        public int Columns { get; }

        public GameBoard(char[,] board, int rows, int columns)
        {
            this.Board = board;
            this.Rows = rows;
            this.Columns = columns;
        }

        public object Clone()
        {
            return new GameBoard((char[,])Board.Clone(), Rows, Columns);
        }
    }
}
