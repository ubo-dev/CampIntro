using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using System;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new CheckPersonManager());
            Gamer gamer = new Gamer()
            {
                FirstName = "Umut Bilal",
                LastName = "Okur",
                DateOfBirth = new DateTime(2001, 12, 9),
                NationalityId = "22222222222"
            };
            gamerManager.add(gamer);
            gamerManager.update(gamer);
            gamerManager.delete(gamer);

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.addCampaign(gamer);
            campaignManager.updateCampaign(gamer);
            campaignManager.removeCampaign(gamer);



        }
    }
}
