using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public abstract class Unit : GameObject
    {
        private bool alive;
        private float hp;
        private const float maxHp = 40;

        public Unit(int objectId, string objectName): base(objectId, objectName)
        {
            hp = maxHp;
            alive = true;
        }

        public bool isAlive()
        {
            return alive;
        }

        public float getHp()
        {
            return hp;
        }

        public void receiveDamage(float damage)
        {
            if (!alive || damage <= 0) return; 

            hp -= damage;

            if (hp <= 0)
            {
                hp = 0;
                alive = false;
            }
        }
    }
}