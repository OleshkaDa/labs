using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public abstract class Building : GameObject
    {
        private bool built;
        private float hp = 50;

        public Building(int objectId, string objectName)
            : base(objectId, objectName)
        {
            built = false;
        }

        public bool isBuilt()
        {
            return built;
        }

        protected void build()
        {
            built = true;
        }

        protected void destroy()
        {
            built = false;
        }
        //правка после отправки в гит
        public float getHp => hp;


        public void receiveDamage(float damage)
        {
            if (!built || damage <= 0) return;

            hp -= damage;

            if (hp <= 0)
            {
                hp = 0;
                destroy();
            }
        }
    }
}
