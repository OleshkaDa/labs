using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tp_lab3
{
    class Singleton
    {
        private static Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get { return instance; }
        }

        public int TimeMinutes = 10;
    }
}

