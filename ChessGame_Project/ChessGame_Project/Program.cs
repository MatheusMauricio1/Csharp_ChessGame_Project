
using board;

namespace ChessGame_Project
{
    class Program
    {
        static void Main(string[] args) 
        {
            Board brd = new Board(8, 8);

            Screen.printBoard(brd);           
        }

    }

}