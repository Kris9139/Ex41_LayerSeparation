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

        internal void InsertPet(string PetName, string PetType, decimal PetWeight, int OwnerID)
        {
            database.InsertPet(PetName, PetType, PetWeight, OwnerID);
        }

        internal void ShowAllPets()
        {
            database.ShowAllPets();
        }

        internal string ShowOwnerByLastname(string lastName)
        {
            string returnMe = database.ShowOwnerByLastname(lastName);
            return returnMe;
        }

        internal string ShowOwnerByEmail(string OwnerEmail)
        {
            string returnEmail = database.ShowOwnerByEmail(OwnerEmail);
            return returnEmail;
        }

        internal void ShowOwnersPets()
        {
            database.ShowOwnersPets();
        }
    }
}
