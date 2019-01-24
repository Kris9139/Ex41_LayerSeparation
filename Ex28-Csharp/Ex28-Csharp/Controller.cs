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

        public void InsertPet(string PetName, string PetType, decimal PetWeight, int OwnerID)
        {
            database.InsertPet(PetName, PetType, PetWeight, OwnerID);
        }

        public void ShowAllPets()
        {
            database.ShowAllPets();
        }

        public string ShowOwnerByLastname(string lastName)
        {
            string returnMe = database.ShowOwnerByLastname(lastName);
            return returnMe;
        }

        public string ShowOwnerByEmail(string OwnerEmail)
        {
            string returnEmail = database.ShowOwnerByEmail(OwnerEmail);
            return returnEmail;
        }

        public string ShowOwnersPets(int OwnerID)
        {
            string returnPets = database.ShowOwnersPets(OwnerID);
            return returnPets;
        }
    }
}
