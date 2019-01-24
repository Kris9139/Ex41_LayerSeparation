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
            controller.ShowAllPets();
        }



        
    }
}
