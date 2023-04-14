
using board;
using chess;
using System.Linq.Expressions;

namespace ChessGame_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessMatch chessMatch = new ChessMatch();

                while (!chessMatch.finished)
                {
                    try {
                        Console.Clear();
                        Screen.printBoard(chessMatch.brd);
                        Console.WriteLine();
                        Console.WriteLine("Turn #" + chessMatch.turn);
                        Console.WriteLine("Waiting for movements of the player: " + chessMatch.playerTurn);

                        Console.WriteLine();
                        Console.Write("Origin: ");
                        Position origin = Screen.readChessPositions().toPosition();
                        chessMatch.validateOriginPosition(origin);

                        bool[,] possiblePosition = chessMatch.brd.piece(origin).possibleMovements();

                        Console.Clear();
                        Screen.printBoard(chessMatch.brd, possiblePosition);

                        Console.Write("Destiny: ");
                        Position destiny = Screen.readChessPositions().toPosition();
                        chessMatch.validatedDestinyPosition(origin, destiny);

                        chessMatch.executePlay(origin, destiny);

                    }
                    catch (BoardException e) 
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}