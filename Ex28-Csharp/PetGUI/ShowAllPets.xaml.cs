using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Ex28_Csharp;

namespace PetGUI
{
    /// <summary>
    /// Interaction logic for ShowAllPets.xaml
    /// </summary>
    public partial class ShowAllPets : Window
    {
        public ShowAllPets()
        {
            InitializeComponent();
            var gridview = new GridView();
            this.ShowAllPetsLV.View = gridview;
            gridview.Columns.Add(new GridViewColumn { Header = "Pet name", DisplayMemberBinding = new Binding("PetName")});
            gridview.Columns.Add(new GridViewColumn { Header = "Pet type", DisplayMemberBinding = new Binding("PetType") });
            gridview.Columns.Add(new GridViewColumn { Header = "Pet breed", DisplayMemberBinding = new Binding("PetBreed") });
            gridview.Columns.Add(new GridViewColumn { Header = "Pet DOB", DisplayMemberBinding = new Binding("PetDOB") });
            gridview.Columns.Add(new GridViewColumn { Header = "Pet weight", DisplayMemberBinding = new Binding("PetWeight") });
            gridview.Columns.Add(new GridViewColumn { Header = "Owner id", DisplayMemberBinding = new Binding("OwnerID") });

            
            Controller controller = new Controller();

            foreach (string pet in controller.ShowAllPets())
            {
                string[] onePet = pet.Split('\t');
                string petName = onePet[0];
                string petType = onePet[1];
                string petBreed = onePet[2];
                string petDOB = onePet[3];
                string petWeight = onePet[4];
                string ownerID = onePet[5];
                this.ShowAllPetsLV.Items.Add(new Pet { PetName = petName, PetType = petType, PetBreed = petBreed, PetDOB = petDOB, PetWeight = petWeight, OwnerID = ownerID});
            }

            // this.ShowAllPetsLV.Items.Add(new )
        }

        public class Pet
        {
            public string PetName { get; set; }
            public string PetType { get; set; }
            public string PetBreed { get; set; }
            public string PetDOB { get; set; }
            public string PetWeight { get; set; }
            public string OwnerID { get; set; }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
