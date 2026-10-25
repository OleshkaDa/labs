using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    public abstract class GameObject
    {
        private int id;
        private string name;
        private int x;
        private int y;

        public GameObject(int objectId, string objectName)
        {
            id = objectId;
            name = objectName;
            x = 0;
            y = 0;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setPosition(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
    }
}