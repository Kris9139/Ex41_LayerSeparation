using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_Csharp
{
    public class Controller
    {
        Database database = new Database();

        internal void InsertPet()
        {
            database.InsertPet();
        }

        internal void ShowAllPets()
        {
            database.ShowAllPets();
        }

        internal void ShowOwnerByLastname()
        {
            database.ShowAllPets();
        }

        internal void ShowOwnerByEmail()
        {
            database.ShowOwnerByEmail();
        }

        internal void ShowOwnersPets()
        {
            database.ShowOwnersPets();
        }
    }
}
