using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_lab4
{
    interface IMoveHandler
    {
        void Handle(int from, int to);
        void SetNext(IMoveHandler next);
    }

    class BoardHandler : IMoveHandler
    {
        private IMoveHandler next;

        public void SetNext(IMoveHandler handler)
        {
            next = handler;
        }

        public void Handle(int from, int to)
        {
            if (from < 0 || from > 63 || to < 0 || to > 63)
            {
                Console.WriteLine("Ошибка: неправильная клетка.");
                return;
            }

            Console.WriteLine("Проверка доски пройдена.");

            if (next != null)
                next.Handle(from, to);
        }
    }

    class MoveHandler : IMoveHandler
    {
        public void SetNext(IMoveHandler next)
        {
        }

        public void Handle(int from, int to)
        {
            if (from == to)
            {
                Console.WriteLine("Ошибка: нельзя стоять на месте.");
                return;
            }

            Console.WriteLine("Ход принят.");
        }
    }
}