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

    class MoveHistory : IChessIterator
    {
        private string[] moves;
        private int position = 0;

        public void SetMoves(string[] newMoves)
        {
            moves = newMoves;
        }

        public bool HasNext()
        {
            return position < moves.Length;
        }

        public string Next()
        {
            return moves[position++];
        }
    }
}
