namespace library
{
    partial class AvailableBooksForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAvailableBooks;

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
            this.dgvAvailableBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableBooks
            // 
            this.dgvAvailableBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableBooks.Location = new System.Drawing.Point(12, 12);
            this.dgvAvailableBooks.Name = "dgvAvailableBooks";
            this.dgvAvailableBooks.Size = new System.Drawing.Size(460, 237);
            this.dgvAvailableBooks.TabIndex = 0;
            // 
            // AvailableBooksForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.dgvAvailableBooks);
            this.Name = "AvailableBooksForm";
            this.Text = "Available Books";
            this.Load += new System.EventHandler(this.AvailableBooksForm_Load); // This is crucial
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
