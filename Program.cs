using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Toe Game");
            TicTacToe obj = new TicTacToe();
            obj.gameBoard();
            obj.abillityToInput();

        }
    }

}