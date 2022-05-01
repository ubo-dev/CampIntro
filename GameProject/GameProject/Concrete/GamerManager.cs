using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        private ICheckPersonService _checkPersonService;
        public GamerManager(ICheckPersonService checkPersonService)
        {
            _checkPersonService = checkPersonService;
        }
        public void add(Gamer gamer)
        {
            if (_checkPersonService.CheckPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " "+ gamer.LastName + " has been added");
            }
            else throw new Exception(gamer.FirstName + " " + gamer.LastName + " cant be added");
        }

        public void delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " has been deleted");
        }

        public void update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " has been updated");
        }
    }
}
