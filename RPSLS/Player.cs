using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        //member variables
        public string name;
        public int score;
        public int shoot;

        //constructor
        public Player()
        {
            this.score = 0;
        }

        //methods
        public virtual void GetShoot()
        {

        }
       public virtual void SetName()
        {

        }
    }
}
