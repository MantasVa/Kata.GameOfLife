using Xunit;

namespace Kata.GameOfLife.Tests
{
    public class PlayboardTests
    {
        [Fact]
        public void GetNextGeneration_ValidBoard_NextGenerationIsCorrect()
        {
            char[,] actualBoard = new char[,]
            {
                {'`','`','`','`','`','`','`','`' },
                {'`','`','`','`','*','`','`','`' },
                {'`','`','`','*','*','`','`','`' },
                {'`','`','`','`','`','`','`','`' },
            };
            char[,] expectedGameboard = new char[,]
            {
                {'`','`','`','`','`','`','`','`' },
                {'`','`','`','*','*','`','`','`' },
                {'`','`','`','*','*','`','`','`' },
                {'`','`','`','`','`','`','`','`' },
            };
            GameBoard gameboard = new GameBoard(actualBoard, 4, 8);
            Playboard playboard = new Playboard();

            gameboard = playboard.GetNextGeneration(gameboard);


            for (int i = 0; i < gameboard.Rows; i++)
            {
                for (int j = 0; j < gameboard.Columns; j++)
                {
                    Assert.Equal(expectedGameboard[i, j], gameboard.Board[i, j]);
                }
            }
        }

        [Fact]
        public void GetNextGeneration_ValidBoard_FourhtNextGenerationIsCorrect()
        {
            char[,] actualBoard = new char[,]
            {
                {'`','`','`','`','`','`' },
                {'`','*','`','`','*','`' },
                {'`','*','`','`','*','`' },
                {'`','*','`','`','*','`' },
                {'`','`','`','`','`','`' },
            };
            char[,] expectedGameboard = new char[,]
            {
                {'`','`','*','*','`','`' },
                {'`','*','`','`','*','`' },
                {'*','`','`','`','`','*' },
                {'`','*','`','`','*','`' },
                {'`','`','*','*','`','`' },
            };

            GameBoard gameboard = new GameBoard(actualBoard, 5, 6);
            Playboard playboard = new Playboard();

            gameboard = playboard.GetNextGeneration(gameboard);
            gameboard = playboard.GetNextGeneration(gameboard);
            gameboard = playboard.GetNextGeneration(gameboard);

            for (int i = 0; i < gameboard.Rows; i++)
            {
                for (int j = 0; j < gameboard.Columns; j++)
                {
                    Assert.Equal(expectedGameboard[i, j], gameboard.Board[i, j]);
                }
            }
        }
    }
}
