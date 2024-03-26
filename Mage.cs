using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena
{
    internal class Mage: Participants
    {
        private string TypeOfSpells;
        public Mage(int health, int range, string typeOfSpells): base( health, range)
        {
            this.TypeOfSpells = typeOfSpells;
        }
        public override void Attack()
        {
            Console.WriteLine("Mage has attacked");
        }
    }
}
