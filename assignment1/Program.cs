using System;

namespace assignment1
{
    class Program
    {
        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            ChessPiece[,] chessboard = new ChessPiece[8, 8];
            ChessGame chessGame = new ChessGame();
            ChessGame.InitChessboard(chessboard);
            DisplayChessboard(chessboard);
        }
        void DisplayChessboard(ChessPiece[,] chessboard)
        {
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
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }

                    if(col != 0)
                    {
                        DisplayChessPiece(chessboard[row,col]);
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h");
        }
        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if(chessPiece == null)
            {
                Console.Write("  ");
                //break out of method here?
            }
            
            if (chessPiece.color.ToString() == "White")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            switch (chessPiece.type.ToString())
            {
                case "Pawn":
                    Console.Write(" p ");
                    break;
                case "Rook":
                    Console.Write(" r ");
                    break;
                case "Knight":
                    Console.Write(" k ");
                    break;
                case "Bishop":
                    Console.Write(" b ");
                    break;
                case "Queen":
                    Console.Write(" Q ");
                    break;
                case "King":
                    Console.Write(" K ");
                    break;
            }
            Console.ResetColor();
        }
    }
}
