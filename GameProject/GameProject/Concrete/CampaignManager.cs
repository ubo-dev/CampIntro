using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void addCampaign(Gamer gamer)
        {
            Console.WriteLine("Campaign added for " + gamer.FirstName + " " + gamer.LastName);
        }

        public void removeCampaign(Gamer gamer)
        {
            Console.WriteLine("Campaign updated for " + gamer.FirstName + " " + gamer.LastName);
        }

        public void updateCampaign(Gamer gamer)
        {
            Console.WriteLine("Campaign deleted for " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
