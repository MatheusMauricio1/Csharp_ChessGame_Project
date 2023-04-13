using board;
using System.IO.Compression;

namespace chess
{
    class King: Piece 
    {
        public King(Board board, Color color): base(board, color) 
        { 
        }

        public override string ToString()
        {
            return "K";
        }

        private bool mayMove(Position pos)
        {
            Piece p = board.piece(pos);
            return p == null || p.color != color;
        }
        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[board.lines, board.columns];

            Position pos = new Position(0, 0);

            pos.defineValues(position.line - 1, position.column);
            if(board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValues(position.line - 1, position.column +1);
            if (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            
            pos.defineValues(position.line, position.column +1);
            if (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            
            pos.defineValues(position.line + 1, position.column + 1);
            if (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValues(position.line + 1, position.column);
            if (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
           
            pos.defineValues(position.line + 1, position.column -1);
            if (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValues(position.line, position.column - 1);
            if (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            pos.defineValues(position.line - 1, position.column - 1);
            if (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
            }
            return mat;
        }
    }
}
