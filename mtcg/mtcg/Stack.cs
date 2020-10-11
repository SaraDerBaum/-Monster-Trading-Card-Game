using System;
using System.Collections.Generic;
using System.Text;


//user has multiple cards on his stack 
//= collection of all current cards
namespace mtcg
{
    class Stack
    {
        //1 package of cards (5) randomly given to the user
        private Card[5] packageOfCards;
        //all cards on the stack
        private Card[] stack;


        //buy cards from the server or trade them
        public void buyCards() { }
        public void tradeCards() { }
    }
}
