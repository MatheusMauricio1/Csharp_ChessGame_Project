
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
                
                ChessMatch chessMatch = new ChessMatch();

                while(!chessMatch.finished)
                {
                    Console.Clear();
                    Screen.printBoard(chessMatch.brd);

                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.readChessPositions().toPosition();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.readChessPositions().toPosition();

                    chessMatch.executeMovement(origin, destiny);


                }               
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

}