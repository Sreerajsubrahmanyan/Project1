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
    public partial class AvailableBooksForm : Form
    {
        public AvailableBooksForm()
        {
            InitializeComponent();
        }

        // This method handles the Load event of the form
        private void AvailableBooksForm_Load(object sender, EventArgs e)
        {
            LoadAvailableBooks(); // Load available books when the form loads
        }

        private void LoadAvailableBooks()
        {
            DataAccess dal = new DataAccess();
            DataTable availableBooks = dal.GetAvailableBooks();
            dgvAvailableBooks.DataSource = availableBooks;
        }
    }
}