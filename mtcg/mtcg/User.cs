using System;
using System.Collections.Generic;
using System.Text;

namespace mtcg
{
    //can buy cards
    class User
    {
        //User = registered player with these credentials: 
        private string username;
        private string password;
        private int coins;

        //Konstruktor
        public User(string username, string password, int coins)
        {
            this.username = username;
            this.password = password;
            this.coins = 20; //user starts with 20 coins
        }

        //can manage his cards
        //take a look at the cards -> trade them etc
        public void manageCards()
        {

        }

        //user can buy cards
        public void acquireCards()
        {

        }

        //select the best cards for the deck
        public void defineDeck()
        {

        }
      


    }
}
