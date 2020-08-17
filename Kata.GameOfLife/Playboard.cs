using Kata.GameOfLife.Infrastructure;
using System;

namespace Kata.GameOfLife
{
    public class Playboard
    {
        private GameBoard _nextGeneration;
        public GameBoard GetNextGeneration(GameBoard gameboard)
        {
            _nextGeneration = (GameBoard)gameboard.Clone();
            IterateBoard(gameboard);
            return _nextGeneration;
        }

        private void IterateBoard(GameBoard gameboard)
        {

            for (short i = 0; i < gameboard.Rows; i++)
            {
                for (short j = 0; j < gameboard.Columns; j++)
                {
                    CheckCell(gameboard, i, j);
                }
            }
        }

        private void CheckCell(GameBoard gameboard, short i, short j)
        {
            short liveNeighbourCount = 0;

            liveNeighbourCount += CheckNeighbour(gameboard.Board, i + 1, j);
            liveNeighbourCount += CheckNeighbour(gameboard.Board, i + 1, j + 1);
            liveNeighbourCount += CheckNeighbour(gameboard.Board, i + 1, j - 1);
            liveNeighbourCount += CheckNeighbour(gameboard.Board, i, j + 1);
            liveNeighbourCount += CheckNeighbour(gameboard.Board, i, j - 1);
            liveNeighbourCount += CheckNeighbour(gameboard.Board, i - 1, j);
            liveNeighbourCount += CheckNeighbour(gameboard.Board, i - 1, j - 1);
            liveNeighbourCount += CheckNeighbour(gameboard.Board, i - 1, j + 1);

            if (gameboard.Board[i, j] == Configurations.LIVE_CELL_SYMBOL)
            {
                if (liveNeighbourCount < 2)
                    _nextGeneration.Board[i, j] = Configurations.DEAD_CELL_SYMBOL;

                if (liveNeighbourCount > 3)
                    _nextGeneration.Board[i, j] = Configurations.DEAD_CELL_SYMBOL;
            }
            else
            {
                if (liveNeighbourCount == 3)
                    _nextGeneration.Board[i, j] = Configurations.LIVE_CELL_SYMBOL;
            }
        }

        private short CheckNeighbour(char[,] currentGeneration, int row, int column)
        {
            try
            {
                if (currentGeneration[row, column] == Configurations.LIVE_CELL_SYMBOL)
                    return 1;
            }
            catch (Exception) { }

            return 0;
        }
    }
}
