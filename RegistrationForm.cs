using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class RegistrationForm : Form
    {
        private readonly DataAccess dataAccess;

        public RegistrationForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            // Assuming you might have more fields such as email or phone

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            bool result = dataAccess.RegisterUser(username, password);
            if (result)
            {
                MessageBox.Show("Registration successful!");
                this.Close(); // Close the form after successful registration
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }
    }
}