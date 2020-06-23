using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneComenzi
{
    public partial class LoginForm : Form
    {
        DataBase database;
        public LoginForm()
        {
            database = new DataBase();

            if (database.connectToDB() == true)
            {
                InitializeComponent();
            }
        }

        private void onLoginButton(object sender, EventArgs e)
        {
            if( usernameInput.Text.Equals(String.Empty) || passwordInput.Text.Equals(String.Empty) )
            {
                MessageBox.Show("Invalid Username / Password.");
            }

            database.checkUserExists(usernameInput.Text, passwordInput.Text);
        }
    }
}
