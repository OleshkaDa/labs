using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public class Fort : Building, Attacker
    {
        public Fort()
            : base(3, "Fort")
        {
            build();
        }

        private static Random random = new Random();

        public void attack(Unit unit)
        {
            unit.receiveDamage(random.Next(1, 20));
        }
    }
}
