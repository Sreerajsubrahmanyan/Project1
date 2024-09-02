using System;
using System.Windows.Forms;

namespace library
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            BookSearchForm searchBooksForm = new BookSearchForm();
            searchBooksForm.Show();
        }

        private void btnViewAvailableBooks_Click(object sender, EventArgs e)
        {
            AvailableBooksForm availableBooksForm = new AvailableBooksForm();
            availableBooksForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }
    }
}
