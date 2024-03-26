using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena
{
    internal class Archer : Participants
    {
        private string TypeOfBow;
        public Archer(int health, int range, string typeOfBow): base(health, range)
        {
            this.TypeOfBow = typeOfBow;
        }
        public override void Attack()
        {
            Console.WriteLine("Archer has attacked");
        }
    }
}
