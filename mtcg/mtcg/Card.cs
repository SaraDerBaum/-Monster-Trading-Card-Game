using System;
using System.Collections.Generic;
using System.Text;

//card consist of a name and multiple attributes (damage, element type).
//card is either a spell card or a monster card.


namespace mtcg
{
    abstract class Card
    {
        //random befüllen?
        protected string name;
        protected int damage;
        protected string elementTxpe;

        //Konstruktor
        public Card() { }

        protected Card(string name, int damage, string elementTxpe)
        {
            this.name = name;
            this.damage = damage;
            this.elementTxpe = elementTxpe;
        }

        public virtual void attack()
        {

        }
        
    }
}
