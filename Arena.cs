using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena
{
    internal class Arena
    {
        List<Participants> participants;
        public Arena()
        {
            this.participants = new List<Participants>();
        }


        public void AddParticipant(Participants participant)
        {
            this.participants.Add(participant);
        }

        public void PlayAction()
        {
            for (int i = 0; i < this.participants.Count; i++)
            {
                Participants currentParticipant = this.participants[i];
                if (currentParticipant.IsDead())
                {
                    continue;
                }

                for (int j = 0; j < this.participants.Count; i++)
                {
                    Participants otherParticipant = this.participants[j];

                    if (i == j)
                    {
                        // dont do damage
                        continue; // skip
                    }

                    if (otherParticipant.IsDead())
                    {
                        continue;
                    }
                    otherParticipant.TakeDamage(1);

                }

                this.participants[i].TakeDamage(1);
            }
        }
    }
    
}