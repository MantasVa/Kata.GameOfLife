using Kata.GameOfLife.Infrastructure;
using System;

namespace Kata.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[,]
            {
                {'*','*','`','`','*','*' },
                {'`','*','`','*','`','`' },
                {'*','*','*','`','`','*' },
                {'`','`','`','*','`','`' },
                {'`','*','*','*','`','`' }
            };
            GameBoard gameboard = new GameBoard(board, 5, 6);
            Playboard playboard = new Playboard();

            while (true)
            {
                gameboard.Board.Print2DArray();
                gameboard = playboard.GetNextGeneration(gameboard);

                Console.Clear();
            }
        }
    }
}
