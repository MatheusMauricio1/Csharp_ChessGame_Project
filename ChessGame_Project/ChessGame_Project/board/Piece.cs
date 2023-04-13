

namespace board
{
    abstract class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }

        public int qntMovements { get; protected set; }
        public Board board { get; protected set; }
        
        public Piece (Board board, Color color)
        {
            this.position = null; 
            this.board = board;
            this.color = color;
            qntMovements = 0;
        }

        public abstract bool[,] possibleMovements();

        public void incrementQntMovements()
        {
            qntMovements++;
        }

    }
}
