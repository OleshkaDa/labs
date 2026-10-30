
using System;

namespace tp_lab3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== SINGLETON ===");

            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            Console.WriteLine(s1 == s2);
            Console.WriteLine("Время: " + s1.TimeMinutes);

            Console.WriteLine("\n=== FACTORY METHOD ===");

            FactoryMethod kingFactory = new KingFactory();
            IChessPiece king = kingFactory.CreatePiece();
            king.Move();

            FactoryMethod knightFactory = new KnightFactory();
            IChessPiece knight = knightFactory.CreatePiece();
            knight.Move();

            Console.WriteLine("\n=== ABSTRACT FACTORY ===");

            AbstractFactory whiteFactory = new WhiteFactory();
            whiteFactory.CreateRook().Show();
            whiteFactory.CreateBishop().Show();

            AbstractFactory blackFactory = new BlackFactory();
            blackFactory.CreateRook().Show();
            blackFactory.CreateBishop().Show();

            Console.WriteLine("\n=== BUILDER ===");

            IChessGameBuilder builder = new ChessGameBuilder();
            Director director = new Director();

            director.Construct(builder);

            ChessGame game = builder.GetResult();
            game.Show();

            Console.ReadKey();
        }
    }
}
