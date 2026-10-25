using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public class Archer : Unit, Attacker, Moveable
    {
        public Archer()
            : base(1, "Archer")
        {
        }

        private const float Damage = 10;

        public void attack(Unit unit)
        {
            if (!isAlive()) return;
            unit.receiveDamage(Damage);
        }

        public void move(int newX, int newY)
        {
            if (!isAlive()) return;
            setPosition(newX, newY);
        }
    }
}
