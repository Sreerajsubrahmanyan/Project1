using System;
using System.Data;
using System.Windows.Forms;

namespace library
{
    public partial class BookSearchForm : Form
    {
        public BookSearchForm()
        {
            InitializeComponent();
        }

        private void BookSearchForm_Load(object sender, EventArgs e)
        {
            SetPlaceholderText(txtSearchTerm, "Enter search term");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess dal = new DataAccess();
            DataTable results = dal.SearchBooks(txtSearchTerm.Text);
            dgvSearchResults.DataSource = results;
        }

        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };
            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }
    }
}
