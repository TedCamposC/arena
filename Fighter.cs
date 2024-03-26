using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena
{
    internal class Fighter: Participants
    {
        private string TypeOfSword;
        public Fighter(int health, int range, string typeOfSword):base(health,range)
        {
            this.TypeOfSword = typeOfSword;
        }   
        public override void Attack()
        {
            Console.WriteLine("fighter has attacked");
        }
        public void TakeDamage(int damage)
        {
            base.Health = base.Health - damage;
        }

        public bool IsDead()
        {
            if(base.Health <= 0)
                return true;
            
            return false;
        }
        p
    }
}
