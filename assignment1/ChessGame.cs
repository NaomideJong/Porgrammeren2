using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class ChessGame
    {
        public void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                }
            }
        }

        public void DisplayChessboard(ChessPiece[,] chessboard)
        {
            string square = " ";
            int colCounter = chessboard.GetLength(1);

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1) + 1; col++)
                {
                    int evenUneven = (row + col + 1) % 2;
                    if (col == 0)
                    {
                        Console.Write($"{colCounter} ");
                        colCounter--;
                    }
                    else if (evenUneven == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write($"{square,3}");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"{square,3}");
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h");
        }

        public void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order =
                {ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.Queen,
                ChessPieceType.King, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };

            int whitePawns = 1;
            int blackPawns = 6;
            int firstRow = 0;
            int lastRow = chessboard.GetLength(0);
            int counter = 0;

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 1; col < chessboard.GetLength(1) + 1; col++)
                {
                    if (row == 0)
                    {
                        //chessboard.type[row, col] = order[counter];
                        counter++;
                    }
                    else if (row == whitePawns)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
