using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_Csharp
{
    public class PetRepo
    {
        public List<Pet> pets;

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }
    }
}
