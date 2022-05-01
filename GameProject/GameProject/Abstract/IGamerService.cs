using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public interface IGamerService
    {
        void add(Gamer gamer);
        void update(Gamer gamer);
        void delete(Gamer gamer);
    }
}
