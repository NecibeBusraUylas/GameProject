using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "Büşra" && gamer.LastName == "Uylaş" && gamer.YearOfBirth == 1998 && gamer.NationalId == 12345) 
            { 
                return true; 
            }

            else
            {
                return false;
            }
        }
    }
}
