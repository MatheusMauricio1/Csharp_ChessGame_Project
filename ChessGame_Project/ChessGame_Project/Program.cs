
using board;
using chess;

namespace ChessGame_Project
{
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                Board brd = new Board(8, 8);

                brd.insertPiece(new King(brd, Color.White), new Position(0, 0));
                brd.insertPiece(new King(brd, Color.Black), new Position(0, 7));

                Screen.printBoard(brd);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

}