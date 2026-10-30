using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tp_lab3
{
    interface IChessPiece
    {
        void Move();
    }

    class King : IChessPiece
    {
        public void Move()
        {
            Console.WriteLine("Король ходит на одну клетку.");
        }
    }

    class Knight : IChessPiece
    {
        public void Move()
        {
            Console.WriteLine("Конь ходит буквой Г.");
        }
    }

    abstract class FactoryMethod
    {
        public abstract IChessPiece CreatePiece();
    }

    class KingFactory : FactoryMethod
    {
        public override IChessPiece CreatePiece()
        {
            return new King();
        }
    }

    class KnightFactory : FactoryMethod
    {
        public override IChessPiece CreatePiece()
        {
            return new Knight();
        }
    }
}

