
using board;

namespace chess
{
    internal class ChessMatch
    {
        public Board brd {get; private set;}
        private int turn;
        private Color playerTurn;
        public bool finished { get; private set;}

        public ChessMatch()
        {
            brd = new Board(8, 8);
            turn = 1;
            playerTurn = Color.White;
            finished = false;
            putPieceOnTable();
        }

        public void executeMovement(Position origin, Position destiny)
        {
            Piece p = brd.removePiece(origin);
            p.incrementQntMovements();
            Piece capturedPiece = brd.removePiece(destiny);
            brd.insertPiece(p, destiny);
        
        }

        public void putPieceOnTable()
        {
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('c', 1).toPosition());
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('c', 2).toPosition());
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('d', 2).toPosition());
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('e', 2).toPosition());
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('e', 1).toPosition());
            brd.insertPiece(new King(brd, Color.White), new ChessPosition('d', 1).toPosition());

            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('c', 8).toPosition());
            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('c', 7).toPosition());
            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('d', 7).toPosition());
            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('e', 7).toPosition());
            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('e', 8).toPosition());
            brd.insertPiece(new King(brd, Color.Black), new ChessPosition('d', 8).toPosition());
        }
    }
}
