namespace A_Parada_Test_3
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListBoxBooks = new System.Windows.Forms.ListBox();
            this.GroupBoxAddbook = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblISBN = new System.Windows.Forms.Label();
            this.LblAvailable = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextAuthor = new System.Windows.Forms.TextBox();
            this.TextISBN = new System.Windows.Forms.TextBox();
            this.ComboBoxAvailable = new System.Windows.Forms.ComboBox();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.ToolTipBooks = new System.Windows.Forms.ToolTip(this.components);
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCloseBookForm = new System.Windows.Forms.Button();
            this.GroupBoxAddbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxBooks
            // 
            this.ListBoxBooks.FormattingEnabled = true;
            this.ListBoxBooks.ItemHeight = 16;
            this.ListBoxBooks.Location = new System.Drawing.Point(12, 52);
            this.ListBoxBooks.Name = "ListBoxBooks";
            this.ListBoxBooks.Size = new System.Drawing.Size(445, 436);
            this.ListBoxBooks.TabIndex = 0;
            // 
            // GroupBoxAddbook
            // 
            this.GroupBoxAddbook.Controls.Add(this.BtnAddBook);
            this.GroupBoxAddbook.Controls.Add(this.ComboBoxAvailable);
            this.GroupBoxAddbook.Controls.Add(this.TextISBN);
            this.GroupBoxAddbook.Controls.Add(this.TextAuthor);
            this.GroupBoxAddbook.Controls.Add(this.TextName);
            this.GroupBoxAddbook.Controls.Add(this.LblAvailable);
            this.GroupBoxAddbook.Controls.Add(this.LblISBN);
            this.GroupBoxAddbook.Controls.Add(this.LblAuthor);
            this.GroupBoxAddbook.Controls.Add(this.LblName);
            this.GroupBoxAddbook.Location = new System.Drawing.Point(522, 52);
            this.GroupBoxAddbook.Name = "GroupBoxAddbook";
            this.GroupBoxAddbook.Size = new System.Drawing.Size(369, 253);
            this.GroupBoxAddbook.TabIndex = 1;
            this.GroupBoxAddbook.TabStop = false;
            this.GroupBoxAddbook.Text = "Add Book";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(20, 35);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 16);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(20, 74);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(45, 16);
            this.LblAuthor.TabIndex = 1;
            this.LblAuthor.Text = "Author";
            // 
            // LblISBN
            // 
            this.LblISBN.AutoSize = true;
            this.LblISBN.Location = new System.Drawing.Point(20, 113);
            this.LblISBN.Name = "LblISBN";
            this.LblISBN.Size = new System.Drawing.Size(38, 16);
            this.LblISBN.TabIndex = 2;
            this.LblISBN.Text = "ISBN";
            // 
            // LblAvailable
            // 
            this.LblAvailable.AutoSize = true;
            this.LblAvailable.Location = new System.Drawing.Point(6, 152);
            this.LblAvailable.Name = "LblAvailable";
            this.LblAvailable.Size = new System.Drawing.Size(77, 16);
            this.LblAvailable.TabIndex = 3;
            this.LblAvailable.Text = "Is Available";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(89, 32);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(247, 22);
            this.TextName.TabIndex = 4;
            // 
            // TextAuthor
            // 
            this.TextAuthor.Location = new System.Drawing.Point(89, 74);
            this.TextAuthor.Name = "TextAuthor";
            this.TextAuthor.Size = new System.Drawing.Size(247, 22);
            this.TextAuthor.TabIndex = 5;
            // 
            // TextISBN
            // 
            this.TextISBN.Location = new System.Drawing.Point(89, 113);
            this.TextISBN.Name = "TextISBN";
            this.TextISBN.Size = new System.Drawing.Size(247, 22);
            this.TextISBN.TabIndex = 6;
            // 
            // ComboBoxAvailable
            // 
            this.ComboBoxAvailable.FormattingEnabled = true;
            this.ComboBoxAvailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ComboBoxAvailable.Location = new System.Drawing.Point(89, 149);
            this.ComboBoxAvailable.Name = "ComboBoxAvailable";
            this.ComboBoxAvailable.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxAvailable.TabIndex = 7;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnAddBook.Location = new System.Drawing.Point(103, 192);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(145, 37);
            this.BtnAddBook.TabIndex = 8;
            this.BtnAddBook.Text = "Add";
            this.ToolTipBooks.SetToolTip(this.BtnAddBook, "Add Book to catalog");
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnEdit.Location = new System.Drawing.Point(61, 505);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(145, 37);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.ToolTipBooks.SetToolTip(this.BtnEdit, "Edit Selected Book");
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.Location = new System.Drawing.Point(262, 505);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(145, 37);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.ToolTipBooks.SetToolTip(this.BtnDelete, "Delete Selected Book");
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCloseBookForm
            // 
            this.BtnCloseBookForm.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCloseBookForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCloseBookForm.Location = new System.Drawing.Point(704, 505);
            this.BtnCloseBookForm.Name = "BtnCloseBookForm";
            this.BtnCloseBookForm.Size = new System.Drawing.Size(145, 37);
            this.BtnCloseBookForm.TabIndex = 4;
            this.BtnCloseBookForm.Text = "&Close";
            this.ToolTipBooks.SetToolTip(this.BtnCloseBookForm, "Delete Selected Book");
            this.BtnCloseBookForm.UseVisualStyleBackColor = false;
            this.BtnCloseBookForm.Click += new System.EventHandler(this.BtnCloseBookForm_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.BtnCloseBookForm;
            this.ClientSize = new System.Drawing.Size(971, 591);
            this.Controls.Add(this.BtnCloseBookForm);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.GroupBoxAddbook);
            this.Controls.Add(this.ListBoxBooks);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Books";
            this.GroupBoxAddbook.ResumeLayout(false);
            this.GroupBoxAddbook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxBooks;
        private System.Windows.Forms.GroupBox GroupBoxAddbook;
        private System.Windows.Forms.ComboBox ComboBoxAvailable;
        private System.Windows.Forms.TextBox TextISBN;
        private System.Windows.Forms.TextBox TextAuthor;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LblAvailable;
        private System.Windows.Forms.Label LblISBN;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.ToolTip ToolTipBooks;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCloseBookForm;
    }
}