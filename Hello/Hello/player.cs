using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class player
    {
        public string name = "abdullah";
        private int health = 100;
       public  int gethealth()
        {
            return health;
        }
       public  void sethealth(int h)
        {
            health = h;
        }
    }
}
