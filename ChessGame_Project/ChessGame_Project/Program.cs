
using board;
using chess;

namespace ChessGame_Project
{
    class Program
    {
        static void Main(string[] args) 
        {
            Board brd = new Board(8, 8);

            brd.insertPiece(new King(brd, Color.White), new Position(0, 0));

            Screen.printBoard(brd);           
        }

    }

}