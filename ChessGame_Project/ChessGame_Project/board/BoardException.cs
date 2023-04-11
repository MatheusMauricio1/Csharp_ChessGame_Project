
namespace board
{
    internal class BoardException: Exception
    {
        public BoardException(string message) : base(message)
        {
            Console.WriteLine(message); 
        }
    }
}
