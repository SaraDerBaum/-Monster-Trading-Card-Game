using mtcg;
using System;
using System.Collections.Generic;
using System.Text;

//card consist of a name and multiple attributes (damage, element type).
//card is either a spell card or a monster card.


namespace mtcg


{   //card with active attack and damage based on an
    //element type (fire, water, normal). The element type does not effect pure monster fights.

    class MonsterCard : Card
    {
        public void attack()
        {
            Console.WriteLine("Monster is attacking you ");
        }
    }
}
