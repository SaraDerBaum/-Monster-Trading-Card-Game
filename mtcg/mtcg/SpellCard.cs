using System;
using System.Collections.Generic;
using System.Text;

 /*
  * a spell card can attack with an element based spell (again fire, water, normal) which is either
  * effective (eg: water is effective against fire, so damage is doubled)
  * not effective (eg: fire is not effective against water, so damage is halved)
  * no effect (eg: normal monster vs normal spell, no change of damage, direct comparison between damages)
  * */


namespace mtcg
{

    class SpellCard : Card
    {

        private string name;
        private int damage;
        private string elementTxpe;

        public SpellCard(string name, int damage, string elementTxpe)
        {
            this.name = name;
            this.damage = damage;
            this.elementTxpe = elementTxpe;
        }


        public void attack()
        {

        }
    }
}
