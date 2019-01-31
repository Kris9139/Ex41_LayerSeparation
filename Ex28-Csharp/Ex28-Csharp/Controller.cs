using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_Csharp
{
    public class Controller: Subscriber
    {
        Database database = new Database();

        public void InsertPet(string PetName, string PetType, string PetBreed, string PetDOB, decimal PetWeight, int OwnerID)
        {
            database.InsertPet(PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID);
        }

        public List<string> ShowAllPets()
        {

            return database.ShowAllPets();
            
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
