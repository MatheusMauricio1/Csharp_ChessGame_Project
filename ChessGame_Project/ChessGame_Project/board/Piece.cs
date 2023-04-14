

using chess;
using System.IO.Compression;

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


        public bool isTherePossibleMovements()
        {
            bool[,] mat = possibleMovements();
            for(int i = 0; i < board.lines; i++)
            {
                for(int j = 0;j < board.columns; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool mayMoveToPosition(Position pos)
        {
            return possibleMovements()[pos.line, pos.column];
        }
    }
}
