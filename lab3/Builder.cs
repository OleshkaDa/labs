using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace tp_lab3
{
    // Объект, который создаём
    class ChessGame
    {
        public string PlayerName;
        public int TimeMinutes;
        public string Color;

        public void Show()
        {
            Console.WriteLine("Игрок: " + PlayerName);
            Console.WriteLine("Время: " + TimeMinutes + " минут");
            Console.WriteLine("Цвет: " + Color);
        }
    }

    // Интерфейс строителя
    interface IChessGameBuilder
    {
        void BuildPlayer();
        void BuildTime();
        void BuildColor();
        ChessGame GetResult();
    }

    // Конкретный строитель
    class ChessGameBuilder : IChessGameBuilder
    {
        private ChessGame game = new ChessGame();

        public void BuildPlayer()
        {
            game.PlayerName = "Зубенко Михаил Петрович";
        }

        public void BuildTime()
        {
            game.TimeMinutes = 10;
        }

        public void BuildColor()
        {
            game.Color = "Белые";
        }

        public ChessGame GetResult()
        {
            return game;
        }
    }

    // Директор
    class Director
    {
        public void Construct(IChessGameBuilder builder)
        {
            builder.BuildPlayer();
            builder.BuildTime();
            builder.BuildColor();
        }
    }
}

