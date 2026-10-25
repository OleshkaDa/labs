using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public class MobileHouse : Building, Moveable
    {
        public MobileHouse()
            : base(2, "MobileHouse")
        {
            build();
        }

        public void move(int newX, int newY)
        {
            setPosition(newX, newY);
        }
    }
}

