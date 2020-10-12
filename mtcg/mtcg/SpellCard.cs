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
    //a spell card can attack with an element based spell (again fire, water, normal) which is either

    class SpellCard : Card
    {

        public void attack()
        {
            Console.WriteLine("Spell is attacking you ");
        }

    }
        

    
}
