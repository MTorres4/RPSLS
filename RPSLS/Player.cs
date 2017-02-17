using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string name;
        public int score;
        public int shoot;

        public Player()
        {
            this.score = 0;
        }

        public virtual void GetShoot()
        {

        }
       public virtual void SetName()
        {

        }
    }
}
