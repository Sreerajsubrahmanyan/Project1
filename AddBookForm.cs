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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            DataAccess dal = new DataAccess();
            bool success = dal.AddBook(txtBookName.Text, txtAuthor.Text);
            if (success)
            {
                MessageBox.Show("Book added successfully!");
                this.Close(); // Close the form after adding the book
            }
            else
            {
                MessageBox.Show("Failed to add the book.");
            }
        }
    }
}