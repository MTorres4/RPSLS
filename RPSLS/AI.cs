using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        public AI()
        {
            name = "Ralph";
        }

        public override void GetShoot()
        {
            Random rnd = new Random();
            shoot = rnd.Next(5);
        }
        public override void SetName()
        {
        
        }
    }
}
