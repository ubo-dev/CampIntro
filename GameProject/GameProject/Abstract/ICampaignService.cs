using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    internal interface ICampaignService
    {
        void addCampaign(Gamer gamer);
        void updateCampaign(Gamer gamer);
        void removeCampaign(Gamer gamer);

    }
}
