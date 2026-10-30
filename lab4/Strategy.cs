using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tp_lab4
{
    interface IMoveStrategy
    {
        void MakeMove();
    }

    // стратегия 1
    class NormalMove : IMoveStrategy
    {
        public void MakeMove()
        {
            Console.WriteLine("Обычный ход фигуры.");
        }
    }

    //2
    class AttackMove : IMoveStrategy
    {
        public void MakeMove()
        {
            Console.WriteLine("Атакующий ход фигуры.");
        }
    }

    // контекст
    class ChessPlayer
    {
        private IMoveStrategy strategy;

        public void SetStrategy(IMoveStrategy newStrategy)
        {
            strategy = newStrategy;
        }

        public void MakeMove()
        {
            strategy.MakeMove();
        }
    }
}