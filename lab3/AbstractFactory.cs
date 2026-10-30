using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_lab3
{
    interface IRook { void Show(); }
    interface IBishop { void Show(); }

    class WhiteRook : IRook { public void Show() => Console.WriteLine("Белая ладья"); }
    class BlackRook : IRook { public void Show() => Console.WriteLine("Чёрная ладья"); }
    class WhiteBishop : IBishop { public void Show() => Console.WriteLine("Белый слон"); }
    class BlackBishop : IBishop { public void Show() => Console.WriteLine("Чёрный слон"); }

    interface AbstractFactory
    {
        IRook CreateRook();
        IBishop CreateBishop();
    }

    class WhiteFactory : AbstractFactory
    {
        public IRook CreateRook() => new WhiteRook();
        public IBishop CreateBishop() => new WhiteBishop();
    }

    class BlackFactory : AbstractFactory
    {
        public IRook CreateRook() => new BlackRook();
        public IBishop CreateBishop() => new BlackBishop();
    }
}
