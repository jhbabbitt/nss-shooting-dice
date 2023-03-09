using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        private List<string> _taunts;

        public CreativeSmackTalkingPlayer(List<string> taunts) : base("")
        {
            _taunts = taunts;
        }

        public override void Play(Player other)
        {

            Random random = new Random();
            int index = random.Next(_taunts.Count);
            Taunt = _taunts[index];

            base.Play(other);
        }
    }
}


