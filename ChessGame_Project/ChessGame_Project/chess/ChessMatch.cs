
using board;

namespace chess
{
    internal class ChessMatch
    {
        public Board brd {get; private set;}
        public int turn { get; private set; }
        public Color playerTurn;
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

        public void executePlay(Position origin, Position destiny)
        {
            executeMovement(origin, destiny);
            turn++;
            changePlayer();
        }

        public void changePlayer()
        {
            if(playerTurn == Color.White)
            {
                playerTurn = Color.Black;
            }
            else
            {
                playerTurn = Color.White;
            }
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

        public void validateOriginPosition(Position pos)
        {
            if (brd.piece(pos) == null)
            {
                throw new BoardException("There is no piece in this position!");
            }
            if (playerTurn != brd.piece(pos).color)
            {
                throw new BoardException("The chosen piece is not yours!");
            }
            if (!brd.piece(pos).isTherePossibleMovements())
            {
                throw new BoardException("You cann move this piece!");
            }
        }
        
        public void validatedDestinyPosition(Position origin, Position destiny)
        {
            if (!brd.piece(origin).mayMoveToPosition(destiny)) 
            {
                throw new BoardException("You cannot move to the desired position!");
            }
        }
    }
}
