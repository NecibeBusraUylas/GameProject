using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerServive
    {
        IGamerValidationService gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            this.gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(gamerValidationService.Validate(gamer)==true)
            { 
                Console.WriteLine("\nId: " + gamer.Id + "\t Name Surname: " + gamer.FirstName + " " + gamer.LastName + " added!");
            }

            else
            {
                Console.WriteLine("\nValidation failed." +  "\t Name Surname: " + gamer.FirstName + " " + gamer.LastName +  " can not added!");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("\nId: " + gamer.Id + "\t Name Surname: " + gamer.FirstName + " " + gamer.LastName + " deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("\nId: " + gamer.Id + "\t Name Surname: " + gamer.FirstName + " " + gamer.LastName + " updated!");
        }
    }
}