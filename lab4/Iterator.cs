using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_lab4
{
    interface IChessIterator
    {
        bool HasNext();
        string Next();
    }

    class MoveHistory
    {
        private readonly string[] moves;

        public MoveHistory(string[] moves)
        {
            this.moves = moves;
        }

        public IChessIterator CreateIterator()
        {
            return new MoveHistoryIterator(moves);
        }
    }

    class MoveHistoryIterator : IChessIterator
    {
        private readonly string[] moves;
        private int position = 0;

        public MoveHistoryIterator(string[] moves)
        {
            this.moves = moves;
        }

        public bool HasNext()
        {
            return position < moves.Length;
        }

        public string Next()
        {
            if (!HasNext())
                throw new IndexOutOfRangeException("Больше ходов нет.");
            return moves[position++];
        }
    }
}
