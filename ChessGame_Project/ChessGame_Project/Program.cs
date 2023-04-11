
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
                ChessPosition chessPosition = new ChessPosition('a', 2);
                Console.WriteLine(chessPosition.toPosition());
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

}