using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena
{
    internal class Participants
    {
        protected int Health;
        protected int Range;
        public Participants(int health, int range)
        {
            this.Health = health;
            this.Range = range;
        }
        public virtual void Attack()
        {
            Console.WriteLine("Participant has attacked");

        }


        public void TakeDamage(int damage)
        {
            this.Health = this.Health - damage;
        }

        public bool IsDead()
        {
            if (this.Health <= 0)
                return true;

            return false;
        }
    }
}
