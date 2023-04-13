using board;

namespace chess
{
    class Tower : Piece
    {
        public Tower(Board brd, Color color) : base(brd, color)
        {

        }

        public override string ToString()
        {
            return "T";
        }
        private bool mayMove(Position pos)
        {
            Piece p = board.piece(pos);
            return p == null || p.color != color;
        }
        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[this.board.lines, this.board.columns];

            Position pos = new Position(0, 0);

            pos.defineValues(position.line - 1, position.column);
            while(board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.line = pos.line - 1;
            }

            pos.defineValues(position.line +1, position.column);
            while (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.line = pos.line + 1;
            }

            pos.defineValues(position.line , position.column +1);
            while (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column + 1;
            }

            pos.defineValues(position.line, position.column - 1);
            while (board.validPosition(pos) && mayMove(pos))
            {
                mat[pos.line, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column - 1;
            }

            return mat;
        }
    }
}