using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_Csharp
{
    public class Database
    {
        string connString = "Server=EALSQL1.eal.local;Database=B_DB18_2018;user id=B_STUDENT18;Password=B_OPENDB18;";
        internal void InsertPet()
        {

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

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                using (SqlCommand cmd = new SqlCommand("InsertPet", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@PetName", SqlDbType.Char).Value = PetName;
                    cmd.Parameters.Add("@PetType", SqlDbType.Char).Value = PetType;
                    cmd.Parameters.Add("@PetWeight", SqlDbType.Float).Value = PetWeight;
                    cmd.Parameters.Add("@OwnerID", SqlDbType.Int).Value = OwnerID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void ShowOwnersPets()
        {
            Console.WriteLine("Owner ID: ");
            string OwnerIDTemp = Console.ReadLine();
            int.TryParse(OwnerIDTemp, out int OwnerID);

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                using (SqlCommand cmd = new SqlCommand("GetInfo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@OwnerID", SqlDbType.Int).Value = OwnerID;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.Clear();
                        Console.WriteLine("OwnerName\t PetName\t PetType\t PetBreed\t AverageLifeExpectancy");

                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}",
                                reader[0].ToString().Replace(" ", string.Empty), reader[1].ToString().Replace(" ", string.Empty), reader[2].ToString().Replace(" ", string.Empty), reader[3].ToString().Replace(" ", string.Empty), reader[4].ToString().Replace(" ", string.Empty));
                        }
                    }
                }
            }
            Console.WriteLine("\nPress any key too exit...");
            Console.ReadKey(true);
        }

        internal void ShowOwnerByEmail()
        {
            Console.WriteLine("Owner Email: ");
            string OwnerEmail = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                using (SqlCommand cmd = new SqlCommand("GetOwnerByEmail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@OwnerEmail", SqlDbType.VarChar).Value = OwnerEmail;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("OwnerID\t OwnerLastName\t OwnerFirstName\t OwnerPhone\t OwnerEmail");

                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}",
                                reader[0].ToString().Replace(" ", string.Empty), reader[1].ToString().Replace(" ", string.Empty), reader[2].ToString().Replace(" ", string.Empty), reader[3].ToString().Replace(" ", string.Empty), reader[4].ToString().Replace(" ", string.Empty));
                        }
                    }
                }
            }
            Console.WriteLine("\nPress any key too exit...");
            Console.ReadKey(true);
        }

        internal string ShowOwnerByLastname(string lastName)
        {
            string returnMe = "";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                using (SqlCommand cmd = new SqlCommand("GetOwnersByLastName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@OwnerLastName", SqlDbType.Char).Value = lastName;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //string.Format("OwnerID\t OwnerLastName\t OwnerFirstName\t OwnerPhone\t OwnerEmail");
                        
                        while (reader.Read())
                        {
                            returnMe = string.Format("{0}\t {1}\t {2}\t {3}\t {4}",
                                reader[0].ToString().Replace(" ", string.Empty), 
                                reader[1].ToString().Replace(" ", string.Empty), 
                                reader[2].ToString().Replace(" ", string.Empty), 
                                reader[3].ToString().Replace(" ", string.Empty), 
                                reader[4].ToString().Replace(" ", string.Empty));
                        }
                        
                    }
                }
            return returnMe;
            }
            Console.WriteLine("\nPress any key too exit...");
            Console.ReadKey(true);

        }

        internal void ShowAllPets()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connString;
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID FROM PET", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("PetName\t PetType\t PetBreed\t PetDOB\t PetWeight\t OwnerID");

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}",
                            reader[0].ToString().Replace(" ", string.Empty), reader[1].ToString().Replace(" ", string.Empty), reader[2].ToString().Replace(" ", string.Empty), reader[3].ToString().Replace(" ", string.Empty), reader[4].ToString().Replace(" ", string.Empty), reader[5].ToString().Replace(" ", string.Empty));
                    }
                }
            }
            Console.WriteLine("\nPress any key too exit...");
            Console.ReadKey(true);
        }
    }
}
