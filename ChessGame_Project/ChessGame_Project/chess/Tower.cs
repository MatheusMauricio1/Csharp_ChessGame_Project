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
    }
}