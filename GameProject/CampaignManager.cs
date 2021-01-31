using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("\nAdded Campaign: " + campaign.CampaignName );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("\nDeleted Campaign: " + campaign.CampaignName );
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("\nUpdated Campaign: " + campaign.CampaignName );
        }
    }
}
