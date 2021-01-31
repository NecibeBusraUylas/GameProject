using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerServive
    {
        void Add(Gamer gamer);

        void Update(Gamer gamer);

        void Delete(Gamer gamer);

    }
}
