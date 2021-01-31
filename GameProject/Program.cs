using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Gamer gamer=new Gamer
            {
                Id = 1,
                FirstName = "Büşra",
                LastName = "Uylaş",
                YearOfBirth = 1998,
                NationalId = 12345,
            };

            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(gamer);


            Game game = new Game
            {
                GameName="Detroit:Become Human",
                GamePrice=142,
                GameType="Action"
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);


            Campaign campaign = new Campaign
            {
                CampaignName="The boss going crazy",
                CampaignAmountOfDiscount="40"
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);


            OrderManager orderManager = new OrderManager();
            orderManager.Sell(game , gamer , campaign);


        }
    }
}
