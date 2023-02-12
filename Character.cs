using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingsMaster
{
    public abstract class Character
    {
        protected int strength;
        protected int position;

        public Character()
        {
            strength = 0;
            position = 0;
        }

        public Character(int strength, int position)
        {
            this.strength = strength;
            this.position = position;
        }

        public int Strength 
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Position 
        {
            get { return position; } 
            set { position = value; }
        }
    }
}
