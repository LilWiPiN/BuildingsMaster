using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingsMaster
{
    public class Enemy: Obstacle, IFighter
    {
        public Enemy(): base()
        {

        }

        public Enemy(int strength, int position): base(strength, position)
        {

        }

        public void Fight()
        {

        }
    }
}
