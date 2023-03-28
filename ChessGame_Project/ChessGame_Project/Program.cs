
using board;

namespace ChessGame_Project
{
    class Program
    {
        static void Main(string[] args) 
        {
            Board brd = new Board(3, 4);
            
            Console.WriteLine(brd);
        }

    }

}