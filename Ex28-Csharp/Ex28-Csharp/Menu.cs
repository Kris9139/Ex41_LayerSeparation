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
                        controller.InsertPet();
                        break;

                    case "2":
                        controller.ShowAllPets();
                        break;

                    case "3":
                        controller.ShowOwnerByLastname();
                        break;

                    case "4":
                        controller.ShowOwnerByEmail();
                        break;

                    case "5":
                        controller.ShowOwnersPets();
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
