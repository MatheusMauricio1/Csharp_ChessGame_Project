

namespace board
{
    internal class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }

        public int qntMovements { get; protected set; }
        public Board board { get; protected set; }
        
        public Piece (Position pos, Board board, Color color)
        {
            this.position = pos; 
            this.board = board;
            this.color = color;
            this.qntMovements = 0;
        }

    }
}
