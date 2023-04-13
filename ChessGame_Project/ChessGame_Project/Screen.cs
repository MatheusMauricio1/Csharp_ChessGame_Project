using board;
using chess;

namespace ChessGame_Project
{
    internal class Screen
    {
        public static void printBoard(Board board)
        {
            for(int i = 0; i < board.lines; i++) 
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j < board.columns; j++)
                {
                    printPieces(board.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void printBoard(Board board, bool[,] possiblePositions)
        {
            ConsoleColor originalBackground = Console.BackgroundColor;
            ConsoleColor alteredBackground = ConsoleColor.DarkGray;

            for (int i = 0; i < board.lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.columns; j++)
                {
                    if (possiblePositions[i, j] == true)
                    {
                        Console.BackgroundColor = alteredBackground;
                    }
                    else
                    {
                        Console.BackgroundColor = originalBackground;
                    }
                    printPieces(board.piece(i, j));
                    Console.BackgroundColor = originalBackground;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = originalBackground;
        }

        public static ChessPosition readChessPositions()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new ChessPosition(column, line);
        }
        public static void printPieces(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (piece.color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
