using System.Windows.Forms;

namespace library
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSearchBooks;
        private Button btnViewAvailableBooks;
        private Button btnRegister;
        private Button btnAddBook; // Add this line

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.btnViewAvailableBooks = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button(); // Add this line
            this.SuspendLayout();
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Location = new System.Drawing.Point(50, 30);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(200, 40);
            this.btnSearchBooks.TabIndex = 0;
            this.btnSearchBooks.Text = "Search Books";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // btnViewAvailableBooks
            // 
            this.btnViewAvailableBooks.Location = new System.Drawing.Point(50, 80);
            this.btnViewAvailableBooks.Name = "btnViewAvailableBooks";
            this.btnViewAvailableBooks.Size = new System.Drawing.Size(200, 40);
            this.btnViewAvailableBooks.TabIndex = 1;
            this.btnViewAvailableBooks.Text = "View Available Books";
            this.btnViewAvailableBooks.UseVisualStyleBackColor = true;
            this.btnViewAvailableBooks.Click += new System.EventHandler(this.btnViewAvailableBooks_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(50, 130);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 40);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(50, 180); // Adjust position as needed
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(200, 40);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250); // Adjust size as needed
            this.Controls.Add(this.btnAddBook); // Add this line
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnViewAvailableBooks);
            this.Controls.Add(this.btnSearchBooks);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
        }
    }
}

