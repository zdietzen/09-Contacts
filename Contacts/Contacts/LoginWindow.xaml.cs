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
using Twilio;

namespace Contacts
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    
    
    public partial class LoginWindow : Window
    {
        // This saves my strings and makes them public so i can use them in other scopes!
        public int userRandom = 0;
        public string randomNumber;
        public string randomPin;

        public LoginWindow()
        {
            InitializeComponent();
        }
        
        private void sendPinButton_Click(object sender, RoutedEventArgs e)
        {
           
           
            //Saves the users Telephone number
            string telephoneNumber = numberTextBox.Text;
            

            //Generates a random 4 digit PIN
            Random r = new Random();
            int randomPin = r.Next(0, 9999);
            userRandom = randomPin;

            //this is the twilio API
            string AccountSid = "AC0a0119b0434b620e2778c7eeb28501dc";
            string AuthToken = "1782bd625befa037e679a1150e391cc0";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);


            var message = twilio.SendMessage("+12604683878",telephoneNumber, "Your PIN is: " + randomPin);

            Console.WriteLine(message.Sid);



        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {  
            // This is what jeff helped me understand with saving outside of the scope
            string enteredPIN = pinTextBox.Text;
            int userenteredPIN = Int32.Parse(enteredPIN);
            // This compares the code send and the code entered.
            if (userRandom == userenteredPIN)
            {//This creates a new instance of the object
                MainWindow window = new MainWindow();
                this.Close();
                window.Show();
            }
            //This is part of my if/else statement obviously. It does this if the password wasn't correct.
            else
            {
                MessageBox.Show("Incorrect, Try Again.");
            }
                
        }
    }


}
