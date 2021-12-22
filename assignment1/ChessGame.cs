using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class ChessGame
    {
        public static void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                }
            }
        }

        public static void DisplayChessboard(ChessPiece[,] chessboard)
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

        public static void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order =
                {ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.Queen,
                ChessPieceType.King, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };

            int whitePawns = 1;
            int blackPawns = 6;
            int whiteRow = 0;
            int blackRow = chessboard.GetLength(0);

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                int counter = 0;
                for (int col = 1; col < chessboard.GetLength(1) + 1; col++)
                {
                    if (row == whiteRow)
                    {
                        chessboard[row, col].type = order[counter];
                        chessboard[row, col].color = ChessPieceColor.White;
                        counter++;
                    }
                    else if(row == blackRow)
                    {
                        chessboard[row, col].type = order[counter];
                        chessboard[row, col].color = ChessPieceColor.White;
                        counter++;
                    }
                    else if (row == whitePawns)
                    {
                        chessboard[row, col].type = ChessPieceType.Pawn;
                        chessboard[row, col].color = ChessPieceColor.White;
                    }
                    else if (row == blackPawns)
                    {
                        chessboard[row, col].type = ChessPieceType.Pawn;
                        chessboard[row, col].color = ChessPieceColor.Black;
                    }
                }
            }
        }
    }
}
