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
            ChessGame.DisplayChessboard(chessboard);
        }
    }
}
