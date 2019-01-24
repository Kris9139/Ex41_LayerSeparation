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
    /// Interaction logic for InsertPet.xaml
    /// </summary>
    public partial class InsertPet : Window
    {
        public InsertPet()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();
            controller.InsertPet(Name.Text, Type.Text, Breed.Text, PetDOB.Text, decimal.Parse(Weight.Text), int.Parse(Owner.Text));
        }
    }
}
