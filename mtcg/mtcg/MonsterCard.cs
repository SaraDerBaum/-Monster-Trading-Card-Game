using mtcg;
using System;
using System.Collections.Generic;
using System.Text;


namespace mtcg


{   //card with active attack and damage based on an
    //element type (fire, water, normal). The element type does not effect pure monster fights.

    class MonsterCard : Card
    {

        private string name;
        private int damage;
        private string elementTxpe;

        public MonsterCard(string name, int damage, string elementTxpe)
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
