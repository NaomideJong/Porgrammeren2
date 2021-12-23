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
            chessGame.InitChessboard(chessboard);
            DisplayChessboard(chessboard);
            PlayChess(chessboard);
            Console.ReadKey();
        }

        void PlayChess(ChessPiece[,] chessboard)
        {
            string[] moves;
            do
            {
                Position position = new Position();
                Console.WriteLine("Enter move (e.g. a2 a3): ");
                moves = Console.ReadLine().Split(' ');
                position.String2Position(moves[0]);
                position.String2Position(moves[1]);
                Console.WriteLine($"move from {moves[0]} to {moves[1]}");
            }
            while (moves[0] != "stop");
        }

        void DisplayChessboard(ChessPiece[,] chessboard)
        {
            int colCounter = chessboard.GetLength(1);

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                Console.Write($"{colCounter} ");
                colCounter--;

                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    int evenUneven = (row + col) % 2;

                    if (evenUneven == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    DisplayChessPiece(chessboard[row, col]);
                    Console.ResetColor();

                }
                Console.WriteLine();
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h");
        }

        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece == null)
            {
                Console.Write("   ");
            }
            else
            {
                if (chessPiece.color.ToString() == "Black")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
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
}
