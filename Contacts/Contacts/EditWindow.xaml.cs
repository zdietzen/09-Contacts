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
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private Contact currentContact;

        public void LoadContact(Contact selectedContact)
        {
            currentContact = selectedContact;

            textBoxFirstName.Text = selectedContact.FirstName;

            textBoxLastName.Text = selectedContact.LastName;

            textBoxEmail.Text = selectedContact.Email;

            textBoxPhone.Text = selectedContact.Telephone;

            textBoxAddress1.Text = selectedContact.Address1;

            textBoxAddress2.Text = selectedContact.Address2;

            textBoxCity.Text = selectedContact.City;

            textBoxState.Text = selectedContact.State;

            textBoxZip.Text = selectedContact.Zipcode;
        }
        public EditWindow()

        {
            InitializeComponent();
        }
        private void button_Edit_Click(object sender, RoutedEventArgs e)
        {
            string firstName = textBoxFirstName.Text;

            string lastName = textBoxLastName.Text;

            string email = textBoxEmail.Text;

            string phone = textBoxPhone.Text;

            string address1 = textBoxAddress1.Text;

            string address2 = textBoxAddress2.Text;

            string city = textBoxCity.Text;

            string state = textBoxState.Text;

            string zip = textBoxZip.Text;

            Contact editContact = new Contact();

            editContact.FirstName = firstName;

            editContact.LastName = lastName;

            editContact.Email = email;

            editContact.Telephone = phone;

            editContact.Address1 = address1;

            editContact.Address2 = address2;

            editContact.City = city;

            editContact.State = state;

            editContact.Zipcode = zip;

            MainWindow mainWindow = (MainWindow)Owner;

            mainWindow.ReceiveContact(editContact);

            mainWindow.RefreshGrid();

            Close();
        }
    }
}
