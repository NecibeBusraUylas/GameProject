using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("\nAdded Game: " + game.GameName + "\t Price of Game: " + game.GamePrice + "\t Type of Game: " +game.GameType);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("\nDeleted Game: " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("\nUpdated Game: " + game.GameName);
        }
    }
}
