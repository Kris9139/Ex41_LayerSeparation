using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_Csharp
{
    public class Menu
    {
        Controller controller = new Controller();
        public void ShowMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Database Interaktion\n");
                Console.WriteLine("\t1. Insert a Pet");
                Console.WriteLine("\t2. Show all Pets");
                Console.WriteLine("\t3. Find owner by Lastname");
                Console.WriteLine("\t4. Find owner by Email");
                Console.WriteLine("\t5. Owners Pets");
                Console.WriteLine("\n\t0. Exit");
                Console.Write("\nChoose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Pet Name: ");
                        string PetName = Console.ReadLine();

                        Console.WriteLine("Pet Type: ");
                        string PetType = Console.ReadLine();

                        Console.WriteLine("Pet Weight: ");
                        string PetWeightTemp = Console.ReadLine();

                        decimal.TryParse(PetWeightTemp, out decimal PetWeight);

                        Console.WriteLine("Owner ID: ");
                        string OwnerIDTemp = Console.ReadLine();

                        int.TryParse(OwnerIDTemp, out int OwnerID);

                        //controller.InsertPet(PetName, PetType, PetWeight, OwnerID);

                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey(true);
                        break;

                    case "2":
                        controller.ShowAllPets();
                        break;

                    case "3":
                        Console.WriteLine("Owner Lastname: ");
                        string OwnerLastname = Console.ReadLine();
                        string Output = controller.ShowOwnerByLastname(OwnerLastname);
                        Console.WriteLine(Output);

                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey(true);
                        break;

                    case "4":
                        Console.WriteLine("Owner Email: ");
                        string OwnerEmail = Console.ReadLine();
                        Output = controller.ShowOwnerByEmail(OwnerEmail);
                        Console.WriteLine(Output);

                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey(true);
                        break;

                    case "5":
                        Console.WriteLine("Owner ID: ");
                        OwnerIDTemp = Console.ReadLine();
                        int.TryParse(OwnerIDTemp, out OwnerID);
                        Output = controller.ShowOwnersPets(OwnerID);
                        Console.WriteLine(Output);

                        Console.Write("\nPress any key to exit...");
                        Console.ReadKey(true);
                        
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("This is not an option.");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
