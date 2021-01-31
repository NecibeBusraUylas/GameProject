using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("\n" + game.GameName + " has been sold to " + gamer.FirstName + " " + gamer.LastName + " with " + campaign.CampaignName + " campaign.");
        }
    }
}
