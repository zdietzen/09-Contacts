using Contacts.Classes;
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

namespace Contacts
{
    /// <summary>
    /// Interaction logic for AddContact.xaml
    /// </summary>
    public partial class AddContact : Window
    {
        private Contact currentContact;

        public void LoadContact(Contact newContact)
        {
            currentContact = newContact;
        }        
        public AddContact()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, RoutedEventArgs e)            
        {
            currentContact.FirstName = textBoxFirstName.Text;

            currentContact.LastName = textBoxLastName.Text;

            currentContact.Email = textBoxEmail.Text;

            currentContact.Telephone = textBoxPhone.Text;

            currentContact.Address1 = textBoxAddress1.Text;

            currentContact.Address2 = textBoxAddress2.Text;

            currentContact.City = textBoxCity.Text;

            currentContact.State = textBoxState.Text;

            currentContact.Zipcode = textBoxZip.Text;

            MainWindow mainWindow = (MainWindow)Owner;

            mainWindow.ReceiveContact(currentContact);

            Close();
        }
    }
}
