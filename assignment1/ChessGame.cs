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
                    chessboard[row, col] = null;
                }
            }
            PutChessPieces(chessboard);
        }

        public void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order =
                {ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.Queen,
                ChessPieceType.King, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    ChessPiece piece = new ChessPiece();
                    switch (row)
                    {
                        case 0:
                            piece.type = order[col];
                            piece.color = ChessPieceColor.Black;
                            break;

                        case 1:
                            piece.type = ChessPieceType.Pawn;
                            piece.color = ChessPieceColor.Black;
                            break;

                        case 6:
                            piece.type = ChessPieceType.Pawn;
                            piece.color = ChessPieceColor.White;
                            break;

                        case 7:
                            piece.type = order[col];
                            piece.color = ChessPieceColor.White;
                            break;

                        default:
                            piece = null;
                            break;

                    }
                    
                    chessboard[row, col] = piece;
                }
            }
        }
    }
}
